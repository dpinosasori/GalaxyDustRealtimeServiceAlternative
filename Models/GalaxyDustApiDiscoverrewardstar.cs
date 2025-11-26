using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDiscoverrewardstar
{
    public int Id { get; set; }

    public int? StarId { get; set; }

    public int? DiscoverRewardId { get; set; }

    public virtual GalaxyDustApiDiscoverrewardstat? DiscoverReward { get; set; }

    public virtual GalaxyDustApiStar? Star { get; set; }
}
