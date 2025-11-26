using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAstrobotsize
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAstrobotstat> GalaxyDustApiAstrobotstats { get; set; } = new List<GalaxyDustApiAstrobotstat>();
}
