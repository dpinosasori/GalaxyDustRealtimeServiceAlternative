using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountamirecord
{
    public int Id { get; set; }

    public int CompletedExpeditions { get; set; }

    public int TotalExpeditions { get; set; }

    public int FirstDiscoveredStartCount { get; set; }

    public Guid? AccountId { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }
}
