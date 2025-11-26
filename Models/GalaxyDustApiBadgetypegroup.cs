using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBadgetypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? BadgeId { get; set; }

    public int? BadgeTypeId { get; set; }

    public virtual GalaxyDustApiBadgestat? Badge { get; set; }

    public virtual GalaxyDustApiBadgetype? BadgeType { get; set; }
}
