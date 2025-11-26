using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiItemactivationfeegroup
{
    public int Id { get; set; }

    public double Fee { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiItemactivationfee> GalaxyDustApiItemactivationfees { get; set; } = new List<GalaxyDustApiItemactivationfee>();

    public virtual ICollection<GalaxyDustApiItem> GalaxyDustApiItems { get; set; } = new List<GalaxyDustApiItem>();
}
