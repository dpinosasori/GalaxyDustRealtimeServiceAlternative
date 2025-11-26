using System.Threading.Channels;
using GalaxyDustRealtimeService.Handlers.Fleets;
using GalaxyDustRealtimeService.Hubs;
using GalaxyDustRealtimeService.Models;
using Microsoft.AspNetCore.SignalR;

namespace GalaxyDustRealtimeService.Services;

public class FlightControlService(
    IServiceProvider services,
    IHubContext<TravelHub> hub,
    Channel<long> queue,
    ILogger<FlightControlService> logger)
    : BackgroundService
{
    // Cola de viajes pendientes (reemplazo de Redis/Celery queue)

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("🚀 [WORKER] FlightControlService iniciado y esperando viajes...");
        
        await foreach (var travelId in queue.Reader.ReadAllAsync(stoppingToken))
        {
            logger.LogInformation($"⚙️ [WORKER] Procesando viaje ID: {travelId}");
            _ = ProcessTravelAsync(travelId); 
        }
    }

    private async Task ProcessTravelAsync(long travelId)
    {
        try
        {
            using var scope = services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<GalaxydustContext>();
            
            var travel = await db.GalaxyDustApiTravels.FindAsync((int)travelId);
            if (travel == null)
            {
                logger.LogError($"❌ [WORKER] Viaje {travelId} no encontrado en DB.");
                return;
            }

            var userId = travel.AccountId.ToString();
        
            logger.LogInformation($"👤 [WORKER] Usuario detectado: {userId}. Notificando llegada...");
            
            await hub.Clients.Group($"user_{userId}_travel").SendAsync("TravelUpdate", new 
            { 
                type = "STATUS_CHANGE", 
                status = "ARRIVED_DESTINATION" 
            });
        
            logger.LogInformation($"⚔️ [WORKER] Ejecutando lógica de batalla...");
            
            var results = await FleetLogic.ExecuteJourneyLogic(travel, db);
            
            await hub.Clients.Group($"user_{userId}_travel").SendAsync("TravelUpdate", new 
            { 
                type = "FLEET_UPDATE", 
                data = results 
            });
        
            travel.Status = "COMPLETED";
            await db.SaveChangesAsync();
            logger.LogInformation($"✅ [WORKER] Viaje {travelId} completado exitosamente.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"🔥 [WORKER] Error crítico procesando viaje {travelId}");
        }
    }
}