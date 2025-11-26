using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace GalaxyDustRealtimeService.Hubs;

[Authorize]
public class TravelHub(ILogger<TravelHub> logger) : Hub
{
    public override async Task OnConnectedAsync()
    {
        var userId = Context.UserIdentifier;
        var connectionId = Context.ConnectionId;

        if (string.IsNullOrEmpty(userId))
        {
            logger.LogWarning($"⚠️ [HUB] Usuario conectado sin ID (Token inválido o claim incorrecto). ConnectionId: {connectionId}");
        }
        else
        {
            var groupName = $"user_{userId}_travel";
            
            // Unir al grupo
            await Groups.AddToGroupAsync(connectionId, groupName);
            
            logger.LogInformation($"🔌 [HUB] Usuario {userId} conectado. Unido al grupo: {groupName}");
        }

        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var userId = Context.UserIdentifier;
        if (!string.IsNullOrEmpty(userId))
        {
            var groupName = $"user_{userId}_travel";
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            logger.LogInformation($"❌ [HUB] Usuario {userId} desconectado.");
        }
        
        await base.OnDisconnectedAsync(exception);
    }
}