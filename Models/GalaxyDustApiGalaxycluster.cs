using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiGalaxycluster
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int NumberOfGalaxies { get; set; }

    public double FleetEventPercentage { get; set; }

    public Guid? StelarBodyId { get; set; }

    public double? StarDiscoverProbabilityRateMax { get; set; }

    public double? StarDiscoverProbabilityRateMin { get; set; }

    public double? TravelTimeInMinutes { get; set; }

    public virtual ICollection<GalaxyDustApiGalaxy> GalaxyDustApiGalaxies { get; set; } = new List<GalaxyDustApiGalaxy>();

    public virtual ICollection<GalaxyDustApiGalaxyclustermaxresource> GalaxyDustApiGalaxyclustermaxresources { get; set; } = new List<GalaxyDustApiGalaxyclustermaxresource>();

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
