using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDiscoverlimitedrewardstar
{
    public int Id { get; set; }

    public int? DiscoverLimitedRewardId { get; set; }

    public int? StarId { get; set; }

    public double? Probability { get; set; }

    public virtual GalaxyDustApiDiscoverlimitedrewardstat? DiscoverLimitedReward { get; set; }

    public virtual GalaxyDustApiStar? Star { get; set; }
}
