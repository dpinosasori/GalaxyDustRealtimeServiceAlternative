using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiShipcategorylevelrequirement
{
    public long Id { get; set; }

    public int LevelRequired { get; set; }

    public int ItemCategoryId { get; set; }

    public int ShipLevelUpRequirementId { get; set; }

    public virtual GalaxyDustApiItemcategory ItemCategory { get; set; } = null!;

    public virtual GalaxyDustApiShipleveluprequirement ShipLevelUpRequirement { get; set; } = null!;
}
