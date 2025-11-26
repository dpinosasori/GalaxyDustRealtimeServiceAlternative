using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAstrobottype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAstrobottypegroup> GalaxyDustApiAstrobottypegroups { get; set; } = new List<GalaxyDustApiAstrobottypegroup>();
}
