using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiItemtype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiBlueprintstat> GalaxyDustApiBlueprintstats { get; set; } = new List<GalaxyDustApiBlueprintstat>();

    public virtual ICollection<GalaxyDustApiItem> GalaxyDustApiItems { get; set; } = new List<GalaxyDustApiItem>();

    public virtual ICollection<GalaxyDustApiPackreward> GalaxyDustApiPackrewards { get; set; } = new List<GalaxyDustApiPackreward>();
}
