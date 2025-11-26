using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDiscoverlimitedrewardstatcurrency
{
    public int Id { get; set; }

    public double? CurrencyAmount { get; set; }

    public int? CurrencyId { get; set; }

    public int RewardStatId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiDiscoverlimitedrewardstat RewardStat { get; set; } = null!;
}
