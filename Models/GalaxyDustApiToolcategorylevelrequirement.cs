using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiToolcategorylevelrequirement
{
    public long Id { get; set; }

    public int LevelRequired { get; set; }

    public int ItemCategoryId { get; set; }

    public int ToolLevelUpRequirementId { get; set; }

    public virtual GalaxyDustApiItemcategory ItemCategory { get; set; } = null!;

    public virtual GalaxyDustApiToolleveluprequirement ToolLevelUpRequirement { get; set; } = null!;
}
