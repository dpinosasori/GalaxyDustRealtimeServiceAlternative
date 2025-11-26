using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiXenogonevent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Level { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? FleetGroupNpcId { get; set; }

    public virtual GalaxyDustApiFleetgroupnpc? FleetGroupNpc { get; set; }

    public virtual ICollection<GalaxyDustApiXenogoncurrencyreward> GalaxyDustApiXenogoncurrencyrewards { get; set; } = new List<GalaxyDustApiXenogoncurrencyreward>();

    public virtual ICollection<GalaxyDustApiXenogonitemreward> GalaxyDustApiXenogonitemrewards { get; set; } = new List<GalaxyDustApiXenogonitemreward>();
}
