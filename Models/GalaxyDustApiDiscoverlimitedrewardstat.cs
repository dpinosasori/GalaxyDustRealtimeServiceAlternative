using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDiscoverlimitedrewardstat
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Quantity { get; set; }

    public virtual ICollection<GalaxyDustApiDiscoverlimitedrewardstar> GalaxyDustApiDiscoverlimitedrewardstars { get; set; } = new List<GalaxyDustApiDiscoverlimitedrewardstar>();

    public virtual ICollection<GalaxyDustApiDiscoverlimitedrewardstatcurrency> GalaxyDustApiDiscoverlimitedrewardstatcurrencies { get; set; } = new List<GalaxyDustApiDiscoverlimitedrewardstatcurrency>();

    public virtual ICollection<GalaxyDustApiDiscoverlimitedrewardstatitem> GalaxyDustApiDiscoverlimitedrewardstatitems { get; set; } = new List<GalaxyDustApiDiscoverlimitedrewardstatitem>();
}
