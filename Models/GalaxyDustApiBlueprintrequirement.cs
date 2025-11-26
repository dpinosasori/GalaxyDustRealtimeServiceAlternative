using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBlueprintrequirement
{
    public int Id { get; set; }

    public int? ItemLevel { get; set; }

    public double? CurrencyAmount { get; set; }

    public int BlueprintId { get; set; }

    public int? CurrencyId { get; set; }

    public Guid? ItemId { get; set; }

    public bool IsBurnable { get; set; }

    public int? NumberOfItems { get; set; }

    public int? ItemCategoryId { get; set; }

    public virtual GalaxyDustApiBlueprintstat Blueprint { get; set; } = null!;

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiItemcategory? ItemCategory { get; set; }
}
