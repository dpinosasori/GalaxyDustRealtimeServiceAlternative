using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace GalaxyDustRealtimeService.Hubs;

[Authorize]
public class TravelHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        string? userId = Context.UserIdentifier;
        
        await Groups.AddToGroupAsync(Context.ConnectionId, $"user_{userId}_travel");
        await base.OnConnectedAsync();
    }
}