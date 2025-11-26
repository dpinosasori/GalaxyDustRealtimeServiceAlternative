using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAlliancedeposit
{
    public int Id { get; set; }

    public double Amount { get; set; }

    public int? AllianceId { get; set; }

    public int? CurrencyId { get; set; }

    public virtual GalaxyDustApiAlliance? Alliance { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }
}
