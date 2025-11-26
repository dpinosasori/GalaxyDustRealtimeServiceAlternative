using GalaxyDustRealtimeService.Models;
using Microsoft.EntityFrameworkCore;

namespace GalaxyDustRealtimeService.Handlers.Fleets
{
    public static class FleetLogic
    {
        public class FleetJourneyResult
        {
            public long TravelId { get; set; }
            public double FleetHealth { get; set; }
            public List<object> Events { get; set; } = new();
            public List<object> RewardedItems { get; set; } = new();
            public List<object> RewardedCurrencies { get; set; } = new();
            public BattleStatsResult BattleStats { get; set; }
            public object DiscoverRewards { get; set; }
        }

        public class BattleStatsResult
        {
            public double PlayerDamageDealt { get; set; }
            public double PlayerDamageReceived { get; set; }
            public double EnemyDamageDealt { get; set; }
            public double EnemyDamageReceived { get; set; }
            public string Result { get; set; } // "victory" | "defeat"
            public object EnemyType { get; set; }
        }

        public static async Task<FleetJourneyResult> ExecuteJourneyLogic(GalaxyDustApiTravel travel, GalaxydustContext db)
        {
            // 1. Cargar Datos Auxiliares (Multiplicadores)
            var attackMultipliers = await db.GalaxyDustApiAttackmultipliers
                .ToDictionaryAsync(m => m.AttackType, m => m.Multiplier);

            var fuselageMultipliers = await db.GalaxyDustApiFuselagedamagemultipliers
                .Include(f => f.Fuselage)
                .ToDictionaryAsync(f => f.Fuselage?.Name, f => new Dictionary<string, double>
                {
                    { "Laser", f.Laser ?? 1.0 }, { "Kinetic", f.Kinetic ?? 1.0 },
                    { "Plasma", f.Plasma ?? 1.0 }, { "Ion", f.Ion ?? 1.0 },
                    { "Graviton", f.Graviton ?? 1.0 }
                });

            // 2. Obtener la Data del Viaje (Naves involucradas)
            // Asumimos que TravelData tiene los IDs guardados como Array o JSON en Postgres
            var travelData = await db.GalaxyDustApiTraveldata.FirstOrDefaultAsync(td => td.TravelId == travel.Id);
            if (travelData == null) return null;
            
            var shipIds = travelData.AccountShips ?? new List<string>(); 
            
            var ships = await db.GalaxyDustApiAccountships
                .Include(s => s.Ship)
                .ToListAsync();
            
            double currentFleetHealth = ships.Sum(s => s.Health ?? 0);
            double totalFleetHealth = currentFleetHealth;
            
            var possibleEvents = await db.GalaxyDustApiFleetevents
                .Where(e => e.StelarBodyId == travel.StelarBodyId)
                .ToListAsync();
            
            if (!possibleEvents.Any())
            {
                possibleEvents = await db.GalaxyDustApiFleetevents.Take(10).ToListAsync();
            }
            
            var random = new Random();
            var selectedEvent = possibleEvents[random.Next(possibleEvents.Count)];

            var battleStats = new BattleStatsResult();
            var resultData = new FleetJourneyResult { TravelId = travel.Id };
            
            resultData.Events.Add(new { 
                id = selectedEvent.Id, 
                name = selectedEvent.Name, 
                description = selectedEvent.Name 
            });
            
            if (selectedEvent.FleetGroupNpcId != null)
            {
                // Cargar enemigos
                var enemyShips = await db.GalaxyDustApiEnemyships
                    .Include(es => es.Ship)
                    .Where(es => es.FleetGroupId == selectedEvent.FleetGroupNpcId)
                    .ToListAsync();

                if (enemyShips.Any())
                {
                    double enemyHealth = enemyShips.Sum(e =>
                    {
                        if (e.Ship != null) return e.Ship.TotalHealth;
                        return 0;
                    });

                    double playerShield = 0;
                    foreach (var i in ships.Select(s => s.Ship.Shield)) playerShield += i;
                    
                    double enemyShield = enemyShips.Sum(e =>
                    {
                        if (e.Ship != null) return e.Ship.Shield;
                        return 0;
                    });

                    bool playerTurn = true;
                    
                    while (currentFleetHealth > 0 && enemyHealth > 0)
                    {
                        if (playerTurn)
                        {
                            var (dmg, type) = CalculateDamage(ships, attackMultipliers, fuselageMultipliers);
                            
                            double defense = enemyShips.Sum(e =>
                            {
                                if (e.Ship != null) return e.Ship.Defense;
                                return 0;
                            });
                            
                            double actualDmg = Math.Max((dmg * 1.0) - defense, 0); // Falta aplicar multiplicador de tipo vs defensa

                            if (enemyShield > 0) {
                                enemyShield -= actualDmg;
                                if (enemyShield < 0) { enemyHealth += enemyShield; enemyShield = 0; }
                            } else {
                                enemyHealth -= actualDmg;
                            }
                            battleStats.PlayerDamageDealt += actualDmg;
                        }
                        else 
                        {
                            double enemyDmgRaw = enemyShips.Sum(e =>
                            {
                                if (e.Ship != null) return e.Ship.KineticAttack;
                                return 0;
                            }); 
                            
                            double playerDef = ships.Sum(s => s.Ship.Defense);
                            double actualDmg = Math.Max(enemyDmgRaw - playerDef, 0);

                            if (playerShield > 0) {
                                playerShield -= actualDmg;
                                if (playerShield < 0) { currentFleetHealth += playerShield; playerShield = 0; }
                            } else {
                                currentFleetHealth -= actualDmg;
                            }
                            battleStats.EnemyDamageReceived += actualDmg;
                        }
                        playerTurn = !playerTurn;
                    }

                    battleStats.Result = currentFleetHealth > 0 ? "victory" : "defeat";
                    resultData.BattleStats = battleStats;
                }
            }
            
            if (battleStats.Result == "victory" || selectedEvent.FleetGroupNpcId == null)
            {
                var rewards = await db.GalaxyDustApiFleeteventitems
                    .Include(r => r.ItemToReward)
                    .Where(r => r.EventId == selectedEvent.Id)
                    .ToListAsync();

                foreach (var reward in rewards)
                {
                    resultData.RewardedItems.Add(new { 
                        id = reward.ItemToRewardId, 
                        amount = reward.NumberOfItems 
                    });
                }
            }
            
            if (totalFleetHealth > 0)
            {
                double healthRatio = Math.Max(0, currentFleetHealth) / totalFleetHealth;
                if (double.IsNaN(healthRatio)) healthRatio = 0;

                foreach (var ship in ships)
                {
                    ship.Health = ship.Health * healthRatio;
                }
            }

            travel.Status = "RETURNING";
            await db.SaveChangesAsync();

            resultData.FleetHealth = currentFleetHealth;
            return resultData;
        }
        
        private static (double Damage, string Type) CalculateDamage(
            List<GalaxyDustApiAccountship> ships, 
            Dictionary<string, double> attackMults, 
            Dictionary<string, Dictionary<string, double>> fuselageMults)
        {
            var damageByType = new Dictionary<string, double>
            {
                { "Laser", 0 }, { "Kinetic", 0 }, { "Plasma", 0 }, { "Ion", 0 }, { "Graviton", 0 }
            };
            var fuselageCounts = new Dictionary<string, int>();

            foreach (var s in ships)
            {
                damageByType["Laser"] += (s.Ship.LaserAttack) * attackMults.GetValueOrDefault("Laser", 1);
                damageByType["Kinetic"] += (s.Ship.KineticAttack) * attackMults.GetValueOrDefault("Kinetic", 1);
                // TODO: add another types of fuselages

                string fName = s.Ship.GalaxyDustApiShipfuselagegroups.First().Fuselage?.Name ?? "Unknown";
                fuselageCounts.TryAdd(fName, 0);
                fuselageCounts[fName]++;
            }
            
            var maxDamageType = damageByType.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            double totalDamage = damageByType.Values.Sum();

            if (fuselageCounts.Count == 0) return (totalDamage, maxDamageType);
            {
                var mainFuselage = fuselageCounts.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                if (fuselageMults.TryGetValue(mainFuselage, out var mults))
                {
                    totalDamage *= mults.GetValueOrDefault(maxDamageType, 1.0);
                }
            }

            return (totalDamage, maxDamageType);
        }
    }
}