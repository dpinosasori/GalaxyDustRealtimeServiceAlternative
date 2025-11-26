using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiToolskilllevelgroup
{
    public int Id { get; set; }

    public int Level { get; set; }

    public int BlockGroup { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? SkillId { get; set; }

    public int? ToolId { get; set; }

    public virtual GalaxyDustApiSkillstat? Skill { get; set; }

    public virtual GalaxyDustApiToolstat? Tool { get; set; }
}
