using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStarcluster
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int NumberOfStars { get; set; }

    public int Number { get; set; }

    public string Coords { get; set; } = null!;

    public int GalaxyId { get; set; }

    public Guid? StelarBodyId { get; set; }

    public double? StarDiscoverProbabilityRateMax { get; set; }

    public double? StarDiscoverProbabilityRateMin { get; set; }

    public virtual GalaxyDustApiGalaxy Galaxy { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiStar> GalaxyDustApiStars { get; set; } = new List<GalaxyDustApiStar>();

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
