using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiShiptype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiShiptypegroup> GalaxyDustApiShiptypegroups { get; set; } = new List<GalaxyDustApiShiptypegroup>();
}
