using GalaxyDustRealtimeService.Models;
using GalaxyDustRealtimeService.Models.DataTransfers;
using Microsoft.EntityFrameworkCore;

namespace GalaxyDustRealtimeService.Handlers.Fleets
{
    public static class FleetLogic
    {
        // ==========================================
        // 1. LÓGICA DE MONITOREO Y CONTEXTO (OPTIMIZADA)
        // ==========================================

        /// <summary>
        /// Método principal llamado por el Worker cada tick.
        /// Calcula tiempos y ensambla el contexto completo del viaje.
        /// </summary>
        public static async Task<TravelUpdateDto> CalculateFlightStatusAsync(GalaxyDustApiTravel travel, GalaxydustContext db)
        {
            var now = DateTime.UtcNow;
            
            // Calculamos tiempos basados en CreatedAt para precisión absoluta
            var startTime = travel.CreatedAt; 
            var durationMinutes = travel.TimeToArriveInMinutes ?? 0;
            var arrivalTime = startTime.AddMinutes(durationMinutes);
            
            var totalSeconds = (arrivalTime - startTime).TotalSeconds;
            var elapsedSeconds = (now - startTime).TotalSeconds;

            var remainingSeconds = Math.Max(0, totalSeconds - elapsedSeconds);
            
            // Evitar división por cero si el viaje es instantáneo
            var progress = totalSeconds > 0 
                ? Math.Clamp((elapsedSeconds / totalSeconds) * 100, 0, 100) 
                : 100;

            // Generar mensaje de flavor text
            string tickMessage = GenerateFlightEventMessage(progress);

            // Recuperar el contexto complejo (Naves, Estrella Destino, etc.)
            var contextData = await GetFullTravelContextAsync(travel, db);

            return new TravelUpdateDto
            {
                TravelId = travel.Id,
                Status = travel.Status ?? "UNKNOWN",
                ProgressPercent = progress,
                RemainingMinutes = Math.Round(remainingSeconds / 60, 2),
                TotalMinutes = durationMinutes,
                CurrentMessage = tickMessage,
                Context = contextData
            };
        }

        /// <summary>
        /// Recupera naves, robots y la estrella destino de forma segura y eficiente.
        /// </summary>
        private static async Task<TravelContextDto> GetFullTravelContextAsync(GalaxyDustApiTravel travel, GalaxydustContext db)
        {
            // 1. Cargar TravelData si no vino cargada (para obtener IDs de naves)
            var travelData = travel.GalaxyDustApiTraveldata.FirstOrDefault();
            if (travelData == null)
            {
                // Si por alguna razón Entity Framework no lo cargó en el nivel superior, lo cargamos aquí
                travelData = await db.GalaxyDustApiTraveldata
                    .AsNoTracking().Include(galaxyDustApiTraveldatum => galaxyDustApiTraveldatum.ToolToUse)
                    .FirstOrDefaultAsync(td => td.TravelId == travel.Id);
            }

            // 2. BUSQUEDA DIRECTA DE ESTRELLA (Solución al error de navegación)
            // Usamos el StelarBodyId del viaje para buscar directamente en la tabla de estrellas
            GalaxyDustApiStar? destinationStar = null;
            
            if (travel.StelarBodyId.HasValue)
            {
                destinationStar = await db.GalaxyDustApiStars
                    .AsNoTracking()
                    .Include(s => s.StarStat)  // Datos estadísticos (recursos, etc)
                    .Include(s => s.ColorType) // Tipo visual de la estrella
                    .FirstOrDefaultAsync(s => s.StelarBodyId == travel.StelarBodyId);
            }

            // 3. Obtener IDs de los assets (Naves, Bots, Tools)
            // Convertimos la lista de strings (JSON) a Guids.
            var shipIds = travelData?.AccountShips?.Select(TryParseGuid).Where(g => g != Guid.Empty).ToList() ?? new List<Guid>();
            var botIds = travelData?.AccountAstrobots?.Select(TryParseGuid).Where(g => g != Guid.Empty).ToList() ?? new List<Guid>();
            var toolIds = travelData?.ToolToUse;

            // 4. Cargar Naves (Con tipos y fuselajes para mostrar stats reales)
            var ships = new List<GalaxyDustApiAccountship>();
            if (shipIds.Any())
            {
                ships = await db.GalaxyDustApiAccountships
                    .AsNoTracking()
                    .Include(s => s.Ship)
                        .ThenInclude(sh => sh.GalaxyDustApiShipfuselagegroups)
                            .ThenInclude(fg => fg.Fuselage)
                    .Where(s => shipIds.Contains(s.AccountId))
                    .ToListAsync();
            }

            // 5. Cargar Astrobots
            var bots = new List<GalaxyDustApiAccountastrobot>();
            if (botIds.Any())
            {
                bots = await db.GalaxyDustApiAccountastrobots
                    .AsNoTracking()
                    .Include(b => b.Astrobot)
                    .Where(b => botIds.Contains(b.AccountId))
                    .ToListAsync();
            }

            // 6. Cargar Tools
            var tools = new List<GalaxyDustApiAccounttool>();
            if (toolIds != null) tools.Add(toolIds);

            // 7. Construir y devolver el DTO
            return new TravelContextDto
            {
                DestinationStar = new StarInfoDto
                {
                    Name = destinationStar?.Name ?? "Unknown Sector",
                    Coords = destinationStar?.Coords ?? "0:0:0",
                    Type = destinationStar?.ColorType?.Name ?? "Standard",
                    PlanetCount = destinationStar?.NumberOfPlanets ?? 0,
                    DangerLevel = destinationStar?.StarDiscoverProbabilityRateMax ?? 0,
                    // Si tienes stats de recursos, mapealos aquí
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

                    Astrobots = bots.Select(b => new AstrobotDetailDto
                    {
                        Id = b.IdToken,
                        Name = b.Astrobot?.Name ?? "Bot",
                        Role = "Support", // Lógica custom si tienes roles
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

        private static Guid TryParseGuid(string input)
        {
            return Guid.TryParse(input, out var result) ? result : Guid.Empty;
        }

        private static string GenerateFlightEventMessage(double progress)
        {
            var rng = new Random();
            
            if (progress < 5) return "Initiating launch sequence. Thrusters at 100%.";
            if (progress < 15) return "Exiting planetary orbit. Engaging hyper-drive.";
            if (progress > 85) return "Decelerating for approach. Destination in visual range.";
            if (progress > 95) return "Scanning landing zone. Preparing for orbit.";

            // Mensajes aleatorios (Flavor Text) solo a veces
            if (rng.NextDouble() > 0.7) 
            {
                var events = new[]
                {
                    "Navigational sensors detecting cosmic dust.",
                    "Crew morale is holding steady.",
                    "Optimizing fuel consumption algorithms.",
                    "Communication check: Signal strong.",
                    "Checking shield integrity against micro-meteoroids.",
                    "Scanning local sector for anomalies.",
                    "Receiving encrypted transmission... Ignored.",
                    "Passing through a minor asteroid field.",
                    "Systems nominal. Autopilot engaged."
                };
                return events[rng.Next(events.Length)];
            }

            return "Cruising at sub-light speed.";
        }

        // ==========================================
        // 2. LÓGICA DE FINALIZACIÓN Y COMBATE
        // ==========================================

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

        /// <summary>
        /// Se ejecuta UNA VEZ cuando el viaje llega a destino (RemainingTime <= 0).
        /// Calcula combates, recompensas y actualiza la DB.
        /// </summary>
        public static async Task<FleetJourneyResult?> ExecuteJourneyLogic(GalaxyDustApiTravel travel, GalaxydustContext db)
        {
            // Cargar datos de viaje para saber qué naves participan
            var travelData = await db.GalaxyDustApiTraveldata.FirstOrDefaultAsync(td => td.TravelId == travel.Id);
            if (travelData == null) return null;

            var shipIds = travelData.AccountShips?.Select(TryParseGuid).Where(g => g != Guid.Empty).ToList() ?? new List<Guid>();

            // Cargar Naves (Tracking activado para guardar cambios de vida)
            var ships = await db.GalaxyDustApiAccountships
                .Include(s => s.Ship)
                .Where(s => shipIds.Contains(s.AccountId))
                .ToListAsync();

            double currentFleetHealth = ships.Sum(s => s.Health ?? 0);
            
            // 1. Obtener Eventos Posibles para esta Estrella/Cuerpo
            var possibleEvents = await db.GalaxyDustApiFleetevents
                .Where(e => e.StelarBodyId == travel.StelarBodyId)
                .ToListAsync();

            // Fallback si no hay eventos configurados para este cuerpo
            if (!possibleEvents.Any()) 
            {
                possibleEvents = await db.GalaxyDustApiFleetevents.Take(5).ToListAsync();
            }
            
            // Selección aleatoria del evento
            var selectedEvent = possibleEvents.Any() 
                ? possibleEvents[new Random().Next(possibleEvents.Count)]
                : null;
            
            var result = new FleetJourneyResult { TravelId = travel.Id };
            
            if (selectedEvent != null)
            {
                result.Events.Add(new { name = selectedEvent.Name, description = selectedEvent.Name });

                // --- LÓGICA DE COMBATE ---
                if (selectedEvent.FleetGroupNpcId != null)
                {
                    var enemyShips = await db.GalaxyDustApiEnemyships
                        .Include(es => es.Ship)
                        .Where(es => es.FleetGroupId == selectedEvent.FleetGroupNpcId)
                        .ToListAsync();

                    if (enemyShips.Any())
                    {
                        // TODO: Aquí puedes refinar la fórmula de daño usando los multiplicadores de la DB
                        double enemyPower = enemyShips.Sum(e => (e.Ship?.KineticAttack ?? 0) + (e.Ship?.LaserAttack ?? 0));
                        double playerPower = ships.Sum(s => (s.Ship?.KineticAttack ?? 0) + (s.Ship?.LaserAttack ?? 0));
                        
                        // Daño simple: el enemigo hace el 10% de su poder como daño directo
                        double damageTaken = Math.Max(0, enemyPower * 0.1); 
                        
                        // Aplicar daño a la flota (repartido o al total, simplificado aquí al total)
                        currentFleetHealth -= damageTaken;
                        if (currentFleetHealth < 0) currentFleetHealth = 0;

                        // Distribuir daño en las naves individuales para persistencia
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
                    // Evento sin combate (Pacífico / Exploración)
                    result.BattleStats = new BattleStatsResult { Result = "victory" };
                }

                // --- RECOMPENSAS ---
                if (result.BattleStats?.Result == "victory")
                {
                    var rewards = await db.GalaxyDustApiFleeteventitems
                        .Where(r => r.EventId == selectedEvent.Id)
                        .ToListAsync();
                    
                    foreach(var r in rewards) 
                    {
                        result.RewardedItems.Add(new { itemId = r.ItemToRewardId, amount = r.NumberOfItems });
                        // TODO: Aquí deberías crear registros en GalaxyDustApiAccountbag para dar los items realmente
                    }
                }
            }

            // Actualizar estado del viaje
            travel.Status = "RETURNING"; 
            result.FleetHealth = currentFleetHealth;
            
            // Nota: No llamamos a SaveChangesAsync aquí, lo hace el FlightControlService 
            // para asegurar transaccionalidad con la actualización del status.
            
            return result;
        }

        private static void DistributeDamageToFleet(List<GalaxyDustApiAccountship> ships, double totalDamage)
        {
            if (totalDamage <= 0 || !ships.Any()) return;

            // Estrategia simple: dañar proporcionalmente o a la primera nave viva
            // Aquí dañamos a todas proporcionalmente
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
}