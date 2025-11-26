using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFleetevent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double? Damage { get; set; }

    public double? DamagePercent { get; set; }

    public double? RecoverLife { get; set; }

    public double? RecoverLifePercent { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? FleetGroupNpcId { get; set; }

    public double? ProbabilityOfHappens { get; set; }

    public Guid? StelarBodyId { get; set; }

    public int? DamageTypeId { get; set; }

    public virtual GalaxyDustApiFuselagedamagemultiplier? DamageType { get; set; }

    public virtual GalaxyDustApiFleetgroupnpc? FleetGroupNpc { get; set; }

    public virtual ICollection<GalaxyDustApiFleeteventcurrency> GalaxyDustApiFleeteventcurrencies { get; set; } = new List<GalaxyDustApiFleeteventcurrency>();

    public virtual ICollection<GalaxyDustApiFleeteventitem> GalaxyDustApiFleeteventitems { get; set; } = new List<GalaxyDustApiFleeteventitem>();

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
