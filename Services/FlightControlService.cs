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
        
        var activeTravels = await db.GalaxyDustApiTravels
            .Where(t => t.Status == "DEPARTING" || t.Status == "RETURNING")
            .ToListAsync(ct);

        if (!activeTravels.Any()) return;

        foreach (var travel in activeTravels)
        {
            var updateDto = await FleetLogic.CalculateFlightStatusAsync(travel, db);
            var userId = travel.AccountId.ToString();
            var groupName = $"user_{userId}_travel";
            
            // FLYING TO STAR
            if (updateDto.RemainingMinutes <= 0 && travel.Status == "DEPARTING")
            {
                logger.LogInformation($"⚔️ [FLIGHT CONTROL] Viaje {travel.Id} arribando a destino.");
                
                await hub.Clients.Group(groupName).SendAsync(TravelHub.EVENT_NOTIFICATION, new 
                { 
                    title = "Fleet arrived at destination!",
                    message = $"Your fleet arrive to {updateDto.Context?.DestinationStar?.Name ?? "Unknown"} destination.",
                    type = "info", // info, success, warning, error
                    travelId = travel.Id
                }, ct);
                
                var journeyResult = await FleetLogic.ExecuteJourneyLogic(travel, db);
                
                await hub.Clients.Group(groupName).SendAsync(TravelHub.EVENT_TRAVEL_UPDATE, new 
                { 
                    type = "FLEET_RESULT", 
                    data = journeyResult 
                }, ct);
                
                await db.SaveChangesAsync(ct);
            }
                
            // FLYING BACK
            else if (updateDto.RemainingMinutes <= 0 && travel.Status == "RETURNING")
            {
                logger.LogInformation($"✅ [FLIGHT CONTROL] Viaje {travel.Id} regresó a la base.");
                
                await hub.Clients.Group(groupName).SendAsync(TravelHub.EVENT_NOTIFICATION, new 
                { 
                    title = "Mission success",
                    message = "The fleet has returned to base and unloaded resources.",
                    type = "success",
                    travelId = travel.Id
                }, ct);
                
                travel.Status = "COMPLETED";
                await db.SaveChangesAsync(ct);
                
                await hub.Clients.Group(groupName).SendAsync(TravelHub.EVENT_TRAVEL_UPDATE, new 
                { 
                    type = "TRAVEL_COMPLETED", 
                    travelId = travel.Id 
                }, ct);
            }
                
            // SEND FLIGHT TICK
            else
            {
                await hub.Clients.Group(groupName).SendAsync(TravelHub.EVENT_TRAVEL_UPDATE, new 
                { 
                    type = "FLIGHT_TICK", 
                    data = updateDto 
                }, ct);
            }
        }
    }
}