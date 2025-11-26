using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiGalaxy
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int NumberOfStarClusters { get; set; }

    public int? FleetEventPercentage { get; set; }

    public string Coords { get; set; } = null!;

    public int GalaxyClusterId { get; set; }

    public Guid? StelarBodyId { get; set; }

    public double? StarDiscoverProbabilityRateMax { get; set; }

    public double? StarDiscoverProbabilityRateMin { get; set; }

    public virtual GalaxyDustApiGalaxycluster GalaxyCluster { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiStarcluster> GalaxyDustApiStarclusters { get; set; } = new List<GalaxyDustApiStarcluster>();

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
