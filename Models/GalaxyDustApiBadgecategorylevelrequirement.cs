using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBadgecategorylevelrequirement
{
    public long Id { get; set; }

    public int LevelRequired { get; set; }

    public int BadgeLevelUpRequirementId { get; set; }

    public int ItemCategoryId { get; set; }

    public virtual GalaxyDustApiBadgeleveluprequirement BadgeLevelUpRequirement { get; set; } = null!;

    public virtual GalaxyDustApiItemcategory ItemCategory { get; set; } = null!;
}
