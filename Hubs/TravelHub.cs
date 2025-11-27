using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace GalaxyDustRealtimeService.Hubs;

[Authorize]
public class TravelHub(ILogger<TravelHub> logger) : Hub
{
    public const string EVENT_TRAVEL_UPDATE = "TravelUpdate";
    public const string EVENT_NOTIFICATION = "Notification";
    
    public override async Task OnConnectedAsync()
    {
        var userId = Context.User?.FindFirst("user_id")?.Value; 
        var connectionId = Context.ConnectionId;

        if (string.IsNullOrEmpty(userId))
        {
            // Debugging: Ver qué claims llegaron realmente
            var claims = Context.User?.Claims.Select(c => $"{c.Type}: {c.Value}");
            var claimsString = string.Join(", ", claims ?? Array.Empty<string>());
            
            logger.LogWarning($"⚠️ [HUB] Usuario sin ID. Claims recibidos: [{claimsString}]");
        }
        else
        {
            var groupName = $"user_{userId}_travel";
            await Groups.AddToGroupAsync(connectionId, groupName);
            
            logger.LogInformation($"🔌 [HUB] Usuario {userId} conectado. Unido al grupo: {groupName}");
        }

        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var userId = Context.User?.FindFirst("user_id")?.Value;
        
        if (!string.IsNullOrEmpty(userId))
        {
            var groupName = $"user_{userId}_travel";
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            logger.LogInformation($"❌ [HUB] Usuario {userId} desconectado.");
        }
        
        await base.OnDisconnectedAsync(exception);
    }
}