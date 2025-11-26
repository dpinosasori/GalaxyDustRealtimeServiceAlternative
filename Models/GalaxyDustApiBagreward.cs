using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBagreward
{
    public int Id { get; set; }

    public double? CurrencyAmount { get; set; }

    public double Percentage { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int BagId { get; set; }

    public int? CurrencyId { get; set; }

    public Guid? ItemToRewardId { get; set; }

    public virtual GalaxyDustApiBagstat Bag { get; set; } = null!;

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiItem? ItemToReward { get; set; }
}
