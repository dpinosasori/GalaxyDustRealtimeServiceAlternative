using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAlliancerank
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? MaximumCapacity { get; set; }

    public virtual ICollection<GalaxyDustApiAlliance> GalaxyDustApiAlliances { get; set; } = new List<GalaxyDustApiAlliance>();
}
