using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStructurecategorylevelrequirement
{
    public long Id { get; set; }

    public int LevelRequired { get; set; }

    public int ItemCategoryId { get; set; }

    public int StructureLevelUpRequirementId { get; set; }

    public virtual GalaxyDustApiItemcategory ItemCategory { get; set; } = null!;

    public virtual GalaxyDustApiStructureleveluprequirement StructureLevelUpRequirement { get; set; } = null!;
}
