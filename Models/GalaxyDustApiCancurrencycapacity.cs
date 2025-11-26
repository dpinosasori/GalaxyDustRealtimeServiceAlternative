using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiCancurrencycapacity
{
    public int Id { get; set; }

    public double Capacity { get; set; }

    public int? CanId { get; set; }

    public int? CurrencyId { get; set; }

    public virtual GalaxyDustApiCan? Can { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }
}
