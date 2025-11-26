using System.Threading.Channels;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyDustRealtimeService.Controllers;

[ApiController]
[Route("api/travel")]
public class TravelController(Channel<long> queue) : ControllerBase
{
    [HttpPost("start/{travelId:long}")]
    public async Task<IActionResult> StartTravel(long travelId)
    {
        await queue.Writer.WriteAsync(travelId);
        return Ok();
    }
}