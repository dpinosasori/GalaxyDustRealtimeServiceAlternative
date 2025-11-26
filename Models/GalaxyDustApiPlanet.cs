using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiPlanet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Gravity { get; set; }

    public double Mass { get; set; }

    public double OrbitTime { get; set; }

    public double? Size { get; set; }

    public DateTime? DiscoveredDate { get; set; }

    public double PositionX { get; set; }

    public double PositionY { get; set; }

    public double? Temperature { get; set; }

    public double Atmosphere { get; set; }

    public double Circunference { get; set; }

    public double? Radiation { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int Number { get; set; }

    public string Coords { get; set; } = null!;

    public int? ColorTypeId { get; set; }

    public Guid? FirstDiscovererId { get; set; }

    public int? PlanetStatId { get; set; }

    public Guid? SecondDiscovererId { get; set; }

    public int StarId { get; set; }

    public Guid? StelarBodyId { get; set; }

    public virtual GalaxyDustApiColortype? ColorType { get; set; }

    public virtual GalaxyDustApiAccount? FirstDiscoverer { get; set; }

    public virtual ICollection<GalaxyDustApiAllianceplanet> GalaxyDustApiAllianceplanets { get; set; } = new List<GalaxyDustApiAllianceplanet>();

    public virtual ICollection<GalaxyDustApiDiscoverrewardplanet> GalaxyDustApiDiscoverrewardplanets { get; set; } = new List<GalaxyDustApiDiscoverrewardplanet>();

    public virtual GalaxyDustApiPlanetstat? PlanetStat { get; set; }

    public virtual GalaxyDustApiAccount? SecondDiscoverer { get; set; }

    public virtual GalaxyDustApiStar Star { get; set; } = null!;

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
