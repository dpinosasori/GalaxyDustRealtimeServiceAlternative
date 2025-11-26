using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBadgetype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiBadgetypegroup> GalaxyDustApiBadgetypegroups { get; set; } = new List<GalaxyDustApiBadgetypegroup>();
}
