using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDefensetype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiDefensetypegroup> GalaxyDustApiDefensetypegroups { get; set; } = new List<GalaxyDustApiDefensetypegroup>();
}
