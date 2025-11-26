using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBagtype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiBagtypegroup> GalaxyDustApiBagtypegroups { get; set; } = new List<GalaxyDustApiBagtypegroup>();
}
