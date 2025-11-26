using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAllianceplanet
{
    public int Id { get; set; }

    public int? AllianceId { get; set; }

    public int? PlanetId { get; set; }

    public virtual GalaxyDustApiAlliance? Alliance { get; set; }

    public virtual GalaxyDustApiPlanet? Planet { get; set; }
}
