using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiRepairkittype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiRepairkittypegroup> GalaxyDustApiRepairkittypegroups { get; set; } = new List<GalaxyDustApiRepairkittypegroup>();
}
