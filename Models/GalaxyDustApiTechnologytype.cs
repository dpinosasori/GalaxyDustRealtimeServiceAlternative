using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTechnologytype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiTechnologytypegroup> GalaxyDustApiTechnologytypegroups { get; set; } = new List<GalaxyDustApiTechnologytypegroup>();
}
