using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFirstglobaldiscoverrewardstar
{
    public int Id { get; set; }

    public int? FirstGlobalDiscoverRewardId { get; set; }

    public int? StarId { get; set; }

    public virtual GalaxyDustApiFirstglobaldiscoverrewardstat? FirstGlobalDiscoverReward { get; set; }

    public virtual GalaxyDustApiStar? Star { get; set; }
}
