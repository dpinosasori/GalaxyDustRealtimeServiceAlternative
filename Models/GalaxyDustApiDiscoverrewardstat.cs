using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDiscoverrewardstat
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<GalaxyDustApiDiscoverrewardplanet> GalaxyDustApiDiscoverrewardplanets { get; set; } = new List<GalaxyDustApiDiscoverrewardplanet>();

    public virtual ICollection<GalaxyDustApiDiscoverrewardstar> GalaxyDustApiDiscoverrewardstars { get; set; } = new List<GalaxyDustApiDiscoverrewardstar>();

    public virtual ICollection<GalaxyDustApiDiscoverrewardstatcurrency> GalaxyDustApiDiscoverrewardstatcurrencies { get; set; } = new List<GalaxyDustApiDiscoverrewardstatcurrency>();

    public virtual ICollection<GalaxyDustApiDiscoverrewardstatitem> GalaxyDustApiDiscoverrewardstatitems { get; set; } = new List<GalaxyDustApiDiscoverrewardstatitem>();
}
