using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiColortype
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ColorHex { get; set; }

    public virtual ICollection<GalaxyDustApiPlanet> GalaxyDustApiPlanets { get; set; } = new List<GalaxyDustApiPlanet>();

    public virtual ICollection<GalaxyDustApiStar> GalaxyDustApiStars { get; set; } = new List<GalaxyDustApiStar>();
}
