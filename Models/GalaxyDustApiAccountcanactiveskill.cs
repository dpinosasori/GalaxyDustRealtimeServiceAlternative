using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountcanactiveskill
{
    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public DateTime? DisabledUntil { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? CanId { get; set; }

    public int? SkillId { get; set; }

    public virtual GalaxyDustApiCan? Can { get; set; }

    public virtual GalaxyDustApiSkillstat? Skill { get; set; }
}
