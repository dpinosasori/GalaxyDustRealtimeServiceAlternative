using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFleeteventcurrency
{
    public int Id { get; set; }

    public double? CurrencyAmount { get; set; }

    public int? CurrencyId { get; set; }

    public int EventId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiFleetevent Event { get; set; } = null!;
}
