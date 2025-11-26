using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiPackreward
{
    public int Id { get; set; }

    public double? CurrencyAmount { get; set; }

    public int Percentage { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemToRewardId { get; set; }

    public int PackId { get; set; }

    public int? CurrencyId { get; set; }

    public bool? IsRandom { get; set; }

    public int? ItemTypeId { get; set; }

    public int? NumberOfItems { get; set; }

    public List<string> RarityNames { get; set; } = null!;

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiItem? ItemToReward { get; set; }

    public virtual GalaxyDustApiItemtype? ItemType { get; set; }

    public virtual GalaxyDustApiPackstat Pack { get; set; } = null!;
}
