using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFuselage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiFuselagedamagemultiplier> GalaxyDustApiFuselagedamagemultipliers { get; set; } = new List<GalaxyDustApiFuselagedamagemultiplier>();

    public virtual ICollection<GalaxyDustApiShipfuselagegroup> GalaxyDustApiShipfuselagegroups { get; set; } = new List<GalaxyDustApiShipfuselagegroup>();
}
