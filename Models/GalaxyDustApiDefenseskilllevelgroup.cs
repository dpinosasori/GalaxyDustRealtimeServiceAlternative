using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDefenseskilllevelgroup
{
    public int Id { get; set; }

    public int Level { get; set; }

    public int BlockGroup { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? DefenseId { get; set; }

    public int? SkillId { get; set; }

    public virtual GalaxyDustApiDefensestat? Defense { get; set; }

    public virtual GalaxyDustApiSkillstat? Skill { get; set; }
}
