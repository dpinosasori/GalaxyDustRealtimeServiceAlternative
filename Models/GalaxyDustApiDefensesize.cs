using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDefensesize
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiDefensestat> GalaxyDustApiDefensestats { get; set; } = new List<GalaxyDustApiDefensestat>();
}
