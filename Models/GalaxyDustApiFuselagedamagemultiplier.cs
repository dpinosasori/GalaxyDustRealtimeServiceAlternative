using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFuselagedamagemultiplier
{
    public int Id { get; set; }

    public double? Laser { get; set; }

    public double? Kinetic { get; set; }

    public double? Plasma { get; set; }

    public double? Ion { get; set; }

    public double? Graviton { get; set; }

    public int? FuselageId { get; set; }

    public virtual GalaxyDustApiFuselage? Fuselage { get; set; }

    public virtual ICollection<GalaxyDustApiFleetevent> GalaxyDustApiFleetevents { get; set; } = new List<GalaxyDustApiFleetevent>();
}
