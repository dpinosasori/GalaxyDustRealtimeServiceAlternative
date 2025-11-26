using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDiscoverlimitedrewardstatitem
{
    public int Id { get; set; }

    public int? NumberOfItems { get; set; }

    public Guid? ItemToRewardId { get; set; }

    public int RewardStatId { get; set; }

    public virtual GalaxyDustApiItem? ItemToReward { get; set; }

    public virtual GalaxyDustApiDiscoverlimitedrewardstat RewardStat { get; set; } = null!;
}
