using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStar
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

    public int NumberOfPlanets { get; set; }

    public int Number { get; set; }

    public string Coords { get; set; } = null!;

    public int? ColorTypeId { get; set; }

    public Guid? FirstDiscovererId { get; set; }

    public Guid? SecondDiscovererId { get; set; }

    public int StarClusterId { get; set; }

    public int StarStatId { get; set; }

    public Guid? StelarBodyId { get; set; }

    public double? StarDiscoverProbabilityRateMax { get; set; }

    public double? StarDiscoverProbabilityRateMin { get; set; }

    public virtual GalaxyDustApiColortype? ColorType { get; set; }

    public virtual GalaxyDustApiAccount? FirstDiscoverer { get; set; }

    public virtual ICollection<GalaxyDustApiAccountamistar> GalaxyDustApiAccountamistars { get; set; } = new List<GalaxyDustApiAccountamistar>();

    public virtual ICollection<GalaxyDustApiDiscoverlimitedrewardstar> GalaxyDustApiDiscoverlimitedrewardstars { get; set; } = new List<GalaxyDustApiDiscoverlimitedrewardstar>();

    public virtual ICollection<GalaxyDustApiDiscoverrewardstar> GalaxyDustApiDiscoverrewardstars { get; set; } = new List<GalaxyDustApiDiscoverrewardstar>();

    public virtual ICollection<GalaxyDustApiFirstglobaldiscoverrewardstar> GalaxyDustApiFirstglobaldiscoverrewardstars { get; set; } = new List<GalaxyDustApiFirstglobaldiscoverrewardstar>();

    public virtual ICollection<GalaxyDustApiPlanet> GalaxyDustApiPlanets { get; set; } = new List<GalaxyDustApiPlanet>();

    public virtual GalaxyDustApiAccount? SecondDiscoverer { get; set; }

    public virtual GalaxyDustApiStarcluster StarCluster { get; set; } = null!;

    public virtual GalaxyDustApiStarstat StarStat { get; set; } = null!;

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
