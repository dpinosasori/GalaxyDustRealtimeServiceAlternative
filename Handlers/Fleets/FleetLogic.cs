using GalaxyDustRealtimeService.Models;
using GalaxyDustRealtimeService.Models.DataTransfers;
using Microsoft.EntityFrameworkCore;

namespace GalaxyDustRealtimeService.Handlers.Fleets;

#region Aux Classes

public class FleetJourneyResult
{
    public long TravelId { get; set; }
    public double FleetHealth { get; set; }
    public List<object> Events { get; set; } = new();
    public List<object> RewardedItems { get; set; } = new();
    public BattleStatsResult BattleStats { get; set; }
}

public class BattleStatsResult
{
    public double PlayerDamageDealt { get; set; }
    public double PlayerDamageReceived { get; set; }
    public string Result { get; set; } // "victory" | "defeat"
}

#endregion

public static class FleetLogic
{
    /// <summary>
    /// Método principal llamado por el Worker cada tick.
    /// Calcula tiempos basándose en la fase actual (Ida o Vuelta).
    /// </summary>
    public static async Task<TravelUpdateDto> CalculateFlightStatusAsync(GalaxyDustApiTravel travel, GalaxydustContext db)
    {
        var now = DateTime.UtcNow;

        // 1. Obtener StartTime real desde TravelData (más preciso que travel.CreatedAt)
        // Intentamos usar la propiedad de navegación si está cargada, si no, consultamos.
        var travelData = travel.GalaxyDustApiTraveldata.FirstOrDefault() ?? await db.GalaxyDustApiTraveldata
            .AsNoTracking()
            .FirstOrDefaultAsync(td => td.TravelId == travel.Id);

        // Fallback a CreatedAt si no hay TravelData
        var globalStartTime = travelData?.StartTime ?? travel.CreatedAt;
        var timeToArrive = travel.TimeToArriveInMinutes ?? 0;
        var timeToReturn = travel.TimeToReturnInMinutes ?? timeToArrive; // Si es null, asumimos mismo tiempo

        double durationCurrentLeg = 0;
        double remainingSeconds = 0;
        double progress = 0;
        string status = travel.Status ?? "UNKNOWN";

        // 2. Lógica Diferenciada por Estado
        if (status == "DEPARTING")
        {
            // FASE 1: IDA
            durationCurrentLeg = timeToArrive;
            var arrivalTime = globalStartTime.AddMinutes(durationCurrentLeg);

            var totalSeconds = (arrivalTime - globalStartTime).TotalSeconds;
            var elapsedSeconds = (now - globalStartTime).TotalSeconds;

            remainingSeconds = Math.Max(0, totalSeconds - elapsedSeconds);
            progress = totalSeconds > 0 
                ? Math.Clamp((elapsedSeconds / totalSeconds) * 100, 0, 100) 
                : 100;
        }
        else if (status == "RETURNING")
        {
            // FASE 2: VUELTA
            // El inicio de la vuelta es teóricamente (Inicio Global + Tiempo de Ida)
            // Esto asegura sincronización perfecta aunque el servidor se reinicie.
            var returnStartTime = globalStartTime.AddMinutes(timeToArrive);
            
            durationCurrentLeg = timeToReturn;
            var returnArrivalTime = returnStartTime.AddMinutes(durationCurrentLeg);

            var totalSeconds = (returnArrivalTime - returnStartTime).TotalSeconds;
            var elapsedSeconds = (now - returnStartTime).TotalSeconds;

            remainingSeconds = Math.Max(0, totalSeconds - elapsedSeconds);
            progress = totalSeconds > 0 
                ? Math.Clamp((elapsedSeconds / totalSeconds) * 100, 0, 100) 
                : 100;
        }
        else if (status == "COMPLETED")
        {
            progress = 100;
            remainingSeconds = 0;
        }

        string tickMessage = GenerateFlightEventMessage(progress, status);

        // 3. Contexto Completo (Naves, etc)
        var contextData = await GetFullTravelContextAsync(travel, travelData, db);

        return new TravelUpdateDto
        {
            TravelId = travel.Id,
            Status = status,
            ProgressPercent = progress,
            RemainingMinutes = Math.Round(remainingSeconds / 60, 2),
            TotalMinutes = durationCurrentLeg,
            CurrentMessage = tickMessage,
            Context = contextData
        };
    }

    /// <summary>
    /// Recupera naves, robots y la estrella destino de forma segura.
    /// </summary>
    private static async Task<TravelContextDto> GetFullTravelContextAsync(GalaxyDustApiTravel travel, GalaxyDustApiTraveldatum? travelData, GalaxydustContext db)
    {
        // Si travelData no vino por parámetro (caso raro), lo buscamos
        if (travelData == null)
        {
            travelData = await db.GalaxyDustApiTraveldata
                .AsNoTracking()
                .Include(td => td.ToolToUse)
                .FirstOrDefaultAsync(td => td.TravelId == travel.Id);
        }

        GalaxyDustApiStar? destinationStar = null;

        // Cargar Estrella
        if (travel.StelarBodyId.HasValue)
        {
            destinationStar = await db.GalaxyDustApiStars
                .AsNoTracking()
                .Include(s => s.StarStat)
                .Include(s => s.ColorType)
                .FirstOrDefaultAsync(s => s.StelarBodyId == travel.StelarBodyId);
        }

        // --- CORRECCIÓN DE PARSEO DE IDS (INT) ---
        
        // Naves (Unir sueltas + grupos)
        var rawShipIds = (travelData?.AccountShips ?? new List<string>())
            .Concat(travelData?.AccountShipsInGroups ?? new List<string>());
            
        var shipIds = rawShipIds
            .Select(s => int.TryParse(s, out var i) ? i : 0)
            .Where(i => i > 0)
            .ToList();

        // Astrobots (Unir sueltos + grupos)
        var rawBotIds = (travelData?.AccountAstrobots ?? new List<string>())
            .Concat(travelData?.AccountAstrobotsInGroups ?? new List<string>());

        var botIds = rawBotIds
            .Select(s => int.TryParse(s, out var i) ? i : 0)
            .Where(i => i > 0)
            .ToList();

        // Consultar DB
        var ships = new List<GalaxyDustApiAccountship>();
        if (shipIds.Any())
        {
            ships = await db.GalaxyDustApiAccountships
                .AsNoTracking()
                .Include(s => s.Ship)
                .ThenInclude(sh => sh.GalaxyDustApiShipfuselagegroups)
                .ThenInclude(fg => fg.Fuselage)
                .Where(s => shipIds.Contains(s.Id)) // Filtramos por ID (Primary Key)
                .ToListAsync();
        }

        var astrobots = new List<GalaxyDustApiAccountastrobot>();
        if (botIds.Any())
        {
            astrobots = await db.GalaxyDustApiAccountastrobots
                .AsNoTracking()
                .Include(b => b.Astrobot)
                .Where(b => botIds.Contains(b.Id)) // Filtramos por ID (Primary Key)
                .ToListAsync();
        }

        var tools = new List<GalaxyDustApiAccounttool>();
        if (travelData?.ToolToUseId != null)
        {
            var tool = await db.GalaxyDustApiAccounttools
                .AsNoTracking()
                .Include(t => t.Tool)
                .FirstOrDefaultAsync(t => t.Id == travelData.ToolToUseId);
            if (tool != null) tools.Add(tool);
        }

        return new TravelContextDto
        {
            DestinationStar = new StarInfoDto
            {
                Name = destinationStar?.Name ?? "Unknown Sector",
                Coords = destinationStar?.Coords ?? "0:0:0",
                Type = destinationStar?.ColorType?.Name ?? "Standard",
                PlanetCount = destinationStar?.NumberOfPlanets ?? 0,
                DangerLevel = destinationStar?.StarDiscoverProbabilityRateMax ?? 0,
                ResourceRichness = 0
            },
            Fleet = new FleetCompositionDto
            {
                CurrentFleetHealth = ships.Sum(s => s.Health ?? 0),
                TotalFleetHealth = ships.Sum(s => s.Ship?.TotalHealth ?? 0),
                
                Ships = ships.Select(s => new ShipDetailDto
                {
                    Id = s.IdToken,
                    Name = s.Ship?.Name ?? "Unidentified Ship",
                    Model = s.Ship?.GalaxyDustApiShipfuselagegroups.FirstOrDefault()?.Fuselage?.Name ?? "Standard",
                    Health = s.Health ?? 0,
                    MaxHealth = s.Ship?.TotalHealth ?? 0,
                    Shield = s.Ship?.Shield ?? 0,
                    AttackPower = (s.Ship?.LaserAttack ?? 0) + (s.Ship?.KineticAttack ?? 0)
                }).ToList(),

                Astrobots = astrobots.Select(b => new AstrobotDetailDto
                {
                    Id = b.IdToken,
                    Name = b.Astrobot?.Name ?? "Bot",
                    Role = "Support",
                    Bonus = 0
                }).ToList(),

                Tools = tools.Select(t => new ToolDetailDto
                {
                    Id = t.IdToken,
                    Name = t.Tool?.Name ?? "Tool",
                    Type = "Utility",
                    Durability = t.Tool?.Durability ?? 0
                }).ToList()
            }
        };
    }

    private static string GenerateFlightEventMessage(double progress, string status)
    {
        var rng = new Random();

        if (status == "RETURNING")
        {
            if (progress < 5) return "Leaving orbit. Coordinates set for Home Base.";
            if (progress < 15) return "Jump calculations complete. Returning home.";
            if (progress > 85) return "Home base detected. Beginning descent.";
            if (progress > 95) return "Docking sequence initiated.";
            
            var returnEvents = new[]
            {
                "Cargo secure. Fleet systems nominal.",
                "Analyzing mission data during return flight.",
                "Crew is resting after the expedition.",
                "Engine cooling systems active.",
                "Maintaining sub-light speed to conserve fuel.",
                "Receiving welcome signal from Mothership."
            };
            return returnEvents[rng.Next(returnEvents.Length)];
        }
        else // DEPARTING
        {
            if (progress < 5) return "Initiating launch sequence. Thrusters at 100%.";
            if (progress < 15) return "Exiting planetary orbit. Engaging hyper-drive.";
            if (progress > 85) return "Decelerating for approach. Destination in visual range.";
            if (progress > 95) return "Scanning landing zone. Preparing for orbit.";

            var events = new[]
            {
                "Navigational sensors detecting cosmic dust.",
                "Crew morale is holding steady.",
                "Optimizing fuel consumption algorithms.",
                "Communication check: Signal strong.",
                "Checking shield integrity against micro-meteoroids.",
                "Scanning local sector for anomalies.",
                "Receiving encrypted transmission... Ignored.",
                "Systems nominal. Autopilot engaged."
            };
            return events[rng.Next(events.Length)];
        }
    }

    /// <summary>
    /// Se ejecuta UNA VEZ cuando el viaje llega a destino (RemainingTime <= 0).
    /// </summary>
    public static async Task<FleetJourneyResult?> ExecuteJourneyLogic(GalaxyDustApiTravel travel, GalaxydustContext db)
    {
        var travelData = await db.GalaxyDustApiTraveldata.FirstOrDefaultAsync(td => td.TravelId == travel.Id);
        if (travelData == null) return null;

        // --- CORRECCIÓN DE PARSEO (INT) ---
        var rawShipIds = (travelData.AccountShips ?? new List<string>())
            .Concat(travelData.AccountShipsInGroups ?? new List<string>());
            
        var shipIds = rawShipIds
            .Select(s => int.TryParse(s, out var i) ? i : 0)
            .Where(i => i > 0)
            .ToList();
        
        var ships = await db.GalaxyDustApiAccountships
            .Include(s => s.Ship)
            .Where(s => shipIds.Contains(s.Id)) // Filtro por ID
            .ToListAsync();

        double currentFleetHealth = ships.Sum(s => s.Health ?? 0);
        
        // Lógica de Eventos / Batalla
        var possibleEvents = await db.GalaxyDustApiFleetevents
            .Where(e => e.StelarBodyId == travel.StelarBodyId)
            .ToListAsync();
        
        if (!possibleEvents.Any()) 
        {
            possibleEvents = await db.GalaxyDustApiFleetevents.Take(5).ToListAsync();
        }
        
        var selectedEvent = possibleEvents.Any() 
            ? possibleEvents[new Random().Next(possibleEvents.Count)]
            : null;
            
        var result = new FleetJourneyResult { TravelId = travel.Id };
            
        if (selectedEvent != null)
        {
            result.Events.Add(new { name = selectedEvent.Name, description = selectedEvent.Name });
            
            if (selectedEvent.FleetGroupNpcId != null)
            {
                var enemyShips = await db.GalaxyDustApiEnemyships
                    .Include(es => es.Ship)
                    .Where(es => es.FleetGroupId == selectedEvent.FleetGroupNpcId)
                    .ToListAsync();

                if (enemyShips.Any())
                {
                    double enemyPower = enemyShips.Sum(e => (e.Ship?.KineticAttack ?? 0) + (e.Ship?.LaserAttack ?? 0));
                    double playerPower = ships.Sum(s => (s.Ship?.KineticAttack ?? 0) + (s.Ship?.LaserAttack ?? 0));
                    
                    double damageTaken = Math.Max(0, enemyPower * 0.1); 
                    
                    currentFleetHealth -= damageTaken;
                    if (currentFleetHealth < 0) currentFleetHealth = 0;
                    
                    DistributeDamageToFleet(ships, damageTaken);

                    result.BattleStats = new BattleStatsResult
                    {
                        PlayerDamageDealt = playerPower,
                        PlayerDamageReceived = damageTaken,
                        Result = currentFleetHealth > 0 ? "victory" : "defeat"
                    };
                }
                else
                {
                    result.BattleStats = new BattleStatsResult { Result = "victory", PlayerDamageReceived = 0 };
                }
            }
            else
            {
                result.BattleStats = new BattleStatsResult { Result = "victory" };
            }
            
            if (result.BattleStats?.Result == "victory")
            {
                var rewards = await db.GalaxyDustApiFleeteventitems
                    .Where(r => r.EventId == selectedEvent.Id)
                    .ToListAsync();
                    
                foreach(var r in rewards) 
                {
                    result.RewardedItems.Add(new { itemId = r.ItemToRewardId, amount = r.NumberOfItems });
                }
            }
        }
        
        // CAMBIO DE ESTADO
        travel.Status = "RETURNING"; 
        result.FleetHealth = currentFleetHealth;
        
        return result;
    }

    private static void DistributeDamageToFleet(List<GalaxyDustApiAccountship> ships, double totalDamage)
    {
        if (totalDamage <= 0 || !ships.Any()) return;
        
        double totalHealth = ships.Sum(s => s.Health ?? 0);
        if (totalHealth <= 0) return;

        foreach (var ship in ships)
        {
            if ((ship.Health ?? 0) > 0)
            {
                double ratio = (ship.Health ?? 0) / totalHealth;
                double damagePart = totalDamage * ratio;
                ship.Health -= damagePart;
                if (ship.Health < 0) ship.Health = 0;
            }
        }
    }
}