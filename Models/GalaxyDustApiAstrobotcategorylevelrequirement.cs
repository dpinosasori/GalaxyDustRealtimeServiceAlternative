using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAstrobotcategorylevelrequirement
{
    public long Id { get; set; }

    public int LevelRequired { get; set; }

    public int AstrobotLevelUpRequirementId { get; set; }

    public int ItemCategoryId { get; set; }

    public virtual GalaxyDustApiAstrobotleveluprequirement AstrobotLevelUpRequirement { get; set; } = null!;

    public virtual GalaxyDustApiItemcategory ItemCategory { get; set; } = null!;
}
