using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiPacktype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiPacktypegroup> GalaxyDustApiPacktypegroups { get; set; } = new List<GalaxyDustApiPacktypegroup>();
}
