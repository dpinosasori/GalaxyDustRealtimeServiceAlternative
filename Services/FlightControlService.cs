using System.Threading.Channels;
using GalaxyDustRealtimeService.Handlers.Fleets;
using GalaxyDustRealtimeService.Hubs;
using GalaxyDustRealtimeService.Models;
using Microsoft.AspNetCore.SignalR;

namespace GalaxyDustRealtimeService.Services;

public class FlightControlService : BackgroundService
{
    private readonly IServiceProvider _services;
    private readonly IHubContext<TravelHub> _hubContext;
    
    // Cola de viajes pendientes (reemplazo de Redis/Celery queue)
    private readonly Channel<long> _travelQueue; 

    public FlightControlService(IServiceProvider services, IHubContext<TravelHub> hub, Channel<long> queue)
    {
        _services = services;
        _hubContext = hub;
        _travelQueue = queue;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Escuchar la cola constantemente
        await foreach (var travelId in _travelQueue.Reader.ReadAllAsync(stoppingToken))
        {
            // Lanzar la tarea sin bloquear el loop (Fire and Forget controlado)
            _ = ProcessTravelAsync(travelId); 
        }
    }

    private async Task ProcessTravelAsync(long travelId)
    {
        using (var scope = _services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<GalaxydustContext>();
            
            var travel = await db.GalaxyDustApiTravels.FindAsync(travelId);
            if (travel == null) return;

            var userId = travel.AccountId.ToString();
            
            await _hubContext.Clients.Group($"user_{userId}_travel").SendAsync("TravelUpdate", new 
            { 
                type = "STATUS_CHANGE", 
                status = "ARRIVED_DESTINATION" 
            });
            
            var results = await FleetLogic.ExecuteJourneyLogic(travel, db);
            
            await _hubContext.Clients.Group($"user_{userId}_travel").SendAsync("TravelUpdate", new 
            { 
                type = "FLEET_UPDATE", 
                data = results 
            });

            // 5. Finalizar
            travel.Status = "COMPLETED";
            await db.SaveChangesAsync();
        }
    }
}