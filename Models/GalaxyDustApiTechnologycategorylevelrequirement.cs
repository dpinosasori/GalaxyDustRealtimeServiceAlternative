using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTechnologycategorylevelrequirement
{
    public long Id { get; set; }

    public int LevelRequired { get; set; }

    public int ItemCategoryId { get; set; }

    public int TechnologyLevelUpRequirementId { get; set; }

    public virtual GalaxyDustApiItemcategory ItemCategory { get; set; } = null!;

    public virtual GalaxyDustApiTechnologyleveluprequirement TechnologyLevelUpRequirement { get; set; } = null!;
}
