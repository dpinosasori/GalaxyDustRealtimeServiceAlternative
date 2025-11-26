using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAlliancerole
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public List<string> Permissions { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAccountalliance> GalaxyDustApiAccountalliances { get; set; } = new List<GalaxyDustApiAccountalliance>();
}
