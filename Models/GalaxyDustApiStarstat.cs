using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStarstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double MassMin { get; set; }

    public double MassMax { get; set; }

    public double GravityMin { get; set; }

    public double GravityMax { get; set; }

    public double OrbitTimeMin { get; set; }

    public double OrbitTimeMax { get; set; }

    public double SizeRateMin { get; set; }

    public double SizeRateMax { get; set; }

    public double TemperatureMin { get; set; }

    public double TemperatureMax { get; set; }

    public double AtmosphereMin { get; set; }

    public double AtmosphereMax { get; set; }

    public double CircunferenceMin { get; set; }

    public double CircunferenceMax { get; set; }

    public double RadiationMin { get; set; }

    public double RadiationMax { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiStar> GalaxyDustApiStars { get; set; } = new List<GalaxyDustApiStar>();
}
