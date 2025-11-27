using GalaxyDustRealtimeService.Handlers.Fleets;
using GalaxyDustRealtimeService.Hubs;
using GalaxyDustRealtimeService.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace GalaxyDustRealtimeService.Services;

public class FlightControlService(
    IServiceProvider services,
    IHubContext<TravelHub> hub,
    ILogger<FlightControlService> logger)
    : BackgroundService
{
    // Intervalo de actualización (ticks). 
    // 5 segundos es un buen balance entre "Realtime" y carga de DB.
    private readonly TimeSpan _tickInterval = TimeSpan.FromSeconds(5);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("🚀 [FLIGHT CONTROL] Servicio de monitoreo orbital iniciado.");

        using var timer = new PeriodicTimer(_tickInterval);

        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
            try
            {
                await ProcessActiveFlightsAsync(stoppingToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "🔥 [FLIGHT CONTROL] Error crítico en el ciclo de actualización.");
            }
        }
    }

    private async Task ProcessActiveFlightsAsync(CancellationToken ct)
    {
        using var scope = services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<GalaxydustContext>();

        // 1. Buscar viajes activos (FLYING o RETURNING)
        // No hacemos Include aquí, lo haremos dentro de FleetLogic de forma optimizada
        var activeTravels = await db.GalaxyDustApiTravels
            .Where(t => t.Status == "FLYING" || t.Status == "RETURNING")
            .ToListAsync(ct);

        if (!activeTravels.Any()) return;

        //logger.LogDebug($"[FLIGHT CONTROL] Procesando {activeTravels.Count} vuelos activos...");

        foreach (var travel in activeTravels)
        {
            // 2. Calcular estado actual
            var updateDto = await FleetLogic.CalculateFlightStatusAsync(travel, db);
            var userId = travel.AccountId.ToString();
            var groupName = $"user_{userId}_travel";

            // 3. Verificar si llegó a destino
            if (updateDto.RemainingMinutes <= 0 && travel.Status == "FLYING")
            {
                logger.LogInformation($"⚔️ [FLIGHT CONTROL] Viaje {travel.Id} arribando a destino. Ejecutando lógica de encuentro.");
                    
                // Notificar llegada
                await hub.Clients.Group(groupName).SendAsync("TravelUpdate", new 
                { 
                    type = "STATUS_CHANGE", 
                    status = "ARRIVED_DESTINATION" 
                }, ct);

                // Ejecutar Lógica de Encuentro (Combate/Evento)
                var journeyResult = await FleetLogic.ExecuteJourneyLogic(travel, db);

                // Enviar resultados del encuentro
                await hub.Clients.Group(groupName).SendAsync("TravelUpdate", new 
                { 
                    type = "FLEET_RESULT", 
                    data = journeyResult 
                }, ct);

                // Guardar cambio de estado a RETURNING (ExecuteJourneyLogic lo cambia en memoria)
                await db.SaveChangesAsync(ct);
            }
            else if (updateDto.RemainingMinutes <= 0 && travel.Status == "RETURNING")
            {
                // Lógica de vuelta a casa completada
                logger.LogInformation($"✅ [FLIGHT CONTROL] Viaje {travel.Id} regresó a la base.");
                    
                travel.Status = "COMPLETED";
                await db.SaveChangesAsync(ct);

                await hub.Clients.Group(groupName).SendAsync("TravelUpdate", new 
                { 
                    type = "TRAVEL_COMPLETED", 
                    travelId = travel.Id 
                }, ct);
            }
            else
            {
                // 4. Tick Normal de vuelo (Actualizar UI)
                // Enviamos todos los datos (naves, estrellas) como se pidió.
                await hub.Clients.Group(groupName).SendAsync("TravelUpdate", new 
                { 
                    type = "FLIGHT_TICK", 
                    data = updateDto 
                }, ct);
            }
        }
    }
}