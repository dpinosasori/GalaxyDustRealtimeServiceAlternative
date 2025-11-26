using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiXenogoncurrencyreward
{
    public int Id { get; set; }

    public double? CurrencyAmount { get; set; }

    public int? CurrencyId { get; set; }

    public int XenogonEventId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiXenogonevent XenogonEvent { get; set; } = null!;
}
