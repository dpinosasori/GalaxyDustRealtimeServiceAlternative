using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiMaterializertype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiMaterializertypegroup> GalaxyDustApiMaterializertypegroups { get; set; } = new List<GalaxyDustApiMaterializertypegroup>();
}
