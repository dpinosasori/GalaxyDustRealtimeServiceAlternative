using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiEssencetype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiEssencetypegroup> GalaxyDustApiEssencetypegroups { get; set; } = new List<GalaxyDustApiEssencetypegroup>();
}
