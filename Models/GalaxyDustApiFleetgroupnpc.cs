using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFleetgroupnpc
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiEnemyship> GalaxyDustApiEnemyships { get; set; } = new List<GalaxyDustApiEnemyship>();

    public virtual ICollection<GalaxyDustApiFleetevent> GalaxyDustApiFleetevents { get; set; } = new List<GalaxyDustApiFleetevent>();

    public virtual ICollection<GalaxyDustApiXenogonevent> GalaxyDustApiXenogonevents { get; set; } = new List<GalaxyDustApiXenogonevent>();
}
