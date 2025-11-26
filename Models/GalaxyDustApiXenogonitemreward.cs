using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiXenogonitemreward
{
    public int Id { get; set; }

    public int? NumberOfItems { get; set; }

    public Guid? ItemToRewardId { get; set; }

    public int XenogonEventId { get; set; }

    public virtual GalaxyDustApiItem? ItemToReward { get; set; }

    public virtual GalaxyDustApiXenogonevent XenogonEvent { get; set; } = null!;
}
