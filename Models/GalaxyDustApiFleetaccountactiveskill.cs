using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFleetaccountactiveskill
{
    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? FleetGroupId { get; set; }

    public int? SkillId { get; set; }

    public virtual GalaxyDustApiFleetgroup? FleetGroup { get; set; }

    public virtual GalaxyDustApiSkillstat? Skill { get; set; }
}
