using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountcurrency
{
    public int Id { get; set; }

    public double Ammount { get; set; }

    public Guid AccountId { get; set; }

    public int? CurrencyId { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual GalaxyDustApiCurrency? Currency { get; set; }
}
