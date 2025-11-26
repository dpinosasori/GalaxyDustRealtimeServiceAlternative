using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiCansafedeposit
{
    public int Id { get; set; }

    public double CurrencyAmmount { get; set; }

    public int? CanId { get; set; }

    public int? CurrencyId { get; set; }

    public virtual GalaxyDustApiCan? Can { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }
}
