using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFirstglobaldiscoverrewardstatitem
{
    public int Id { get; set; }

    public int? NumberOfItems { get; set; }

    public Guid? ItemToRewardId { get; set; }

    public int RewardStatId { get; set; }

    public virtual GalaxyDustApiItem? ItemToReward { get; set; }

    public virtual GalaxyDustApiFirstglobaldiscoverrewardstat RewardStat { get; set; } = null!;
}
