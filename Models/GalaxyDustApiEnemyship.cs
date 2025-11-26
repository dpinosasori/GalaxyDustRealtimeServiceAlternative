using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiEnemyship
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? EnemyTypeId { get; set; }

    public int? FleetGroupId { get; set; }

    public int? ShipId { get; set; }

    public virtual GalaxyDustApiEnemytype? EnemyType { get; set; }

    public virtual GalaxyDustApiFleetgroupnpc? FleetGroup { get; set; }

    public virtual GalaxyDustApiShipstat? Ship { get; set; }
}
