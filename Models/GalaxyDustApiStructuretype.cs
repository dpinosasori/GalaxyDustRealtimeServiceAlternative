using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStructuretype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiStructuretypegroup> GalaxyDustApiStructuretypegroups { get; set; } = new List<GalaxyDustApiStructuretypegroup>();
}
