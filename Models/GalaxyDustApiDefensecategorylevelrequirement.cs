using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDefensecategorylevelrequirement
{
    public long Id { get; set; }

    public int LevelRequired { get; set; }

    public int DefenseLevelUpRequirementId { get; set; }

    public int ItemCategoryId { get; set; }

    public virtual GalaxyDustApiDefenseleveluprequirement DefenseLevelUpRequirement { get; set; } = null!;

    public virtual GalaxyDustApiItemcategory ItemCategory { get; set; } = null!;
}
