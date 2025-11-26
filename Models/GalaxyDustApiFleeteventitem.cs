using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFleeteventitem
{
    public int Id { get; set; }

    public int? NumberOfItems { get; set; }

    public int EventId { get; set; }

    public Guid? ItemToRewardId { get; set; }

    public virtual GalaxyDustApiFleetevent Event { get; set; } = null!;

    public virtual GalaxyDustApiItem? ItemToReward { get; set; }
}
