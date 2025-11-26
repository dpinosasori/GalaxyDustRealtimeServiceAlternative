using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTooltype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiTooltypegroup> GalaxyDustApiTooltypegroups { get; set; } = new List<GalaxyDustApiTooltypegroup>();
}
