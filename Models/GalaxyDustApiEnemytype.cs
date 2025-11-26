using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiEnemytype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiEnemyship> GalaxyDustApiEnemyships { get; set; } = new List<GalaxyDustApiEnemyship>();
}
