using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiSkillrequirement
{
    public int Id { get; set; }

    public int? ItemLevel { get; set; }

    public double? CurrencyAmount { get; set; }

    public int? CurrencyId { get; set; }

    public Guid? ItemId { get; set; }

    public int SkillId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiSkillstat Skill { get; set; } = null!;
}
