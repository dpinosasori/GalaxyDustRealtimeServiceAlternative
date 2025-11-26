using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStelarbody
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiDestroyed> GalaxyDustApiDestroyeds { get; set; } = new List<GalaxyDustApiDestroyed>();

    public virtual ICollection<GalaxyDustApiFleetevent> GalaxyDustApiFleetevents { get; set; } = new List<GalaxyDustApiFleetevent>();

    public virtual ICollection<GalaxyDustApiFlyrequirement> GalaxyDustApiFlyrequirements { get; set; } = new List<GalaxyDustApiFlyrequirement>();

    public virtual GalaxyDustApiGalaxy? GalaxyDustApiGalaxy { get; set; }

    public virtual GalaxyDustApiGalaxycluster? GalaxyDustApiGalaxycluster { get; set; }

    public virtual GalaxyDustApiPlanet? GalaxyDustApiPlanet { get; set; }

    public virtual GalaxyDustApiStar? GalaxyDustApiStar { get; set; }

    public virtual GalaxyDustApiStarcluster? GalaxyDustApiStarcluster { get; set; }

    public virtual ICollection<GalaxyDustApiTravel> GalaxyDustApiTravels { get; set; } = new List<GalaxyDustApiTravel>();
}
