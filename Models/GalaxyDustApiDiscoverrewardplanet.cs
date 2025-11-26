using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDiscoverrewardplanet
{
    public int Id { get; set; }

    public int? PlanetId { get; set; }

    public int? DiscoverRewardId { get; set; }

    public virtual GalaxyDustApiDiscoverrewardstat? DiscoverReward { get; set; }

    public virtual GalaxyDustApiPlanet? Planet { get; set; }
}
