using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountamistar
{
    public int Id { get; set; }

    public DateTime? DiscoveredDate { get; set; }

    public Guid? AccountId { get; set; }

    public int? StarId { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }

    public virtual GalaxyDustApiStar? Star { get; set; }
}
