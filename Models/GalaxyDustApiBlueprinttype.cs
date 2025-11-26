using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBlueprinttype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiBlueprinttypegroup> GalaxyDustApiBlueprinttypegroups { get; set; } = new List<GalaxyDustApiBlueprinttypegroup>();
}
