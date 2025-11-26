using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiQmptype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiQmptypegroup> GalaxyDustApiQmptypegroups { get; set; } = new List<GalaxyDustApiQmptypegroup>();
}
