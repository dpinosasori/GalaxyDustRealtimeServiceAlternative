using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiRepairkitfee
{
    public int Id { get; set; }

    public int CurrencyAmount { get; set; }

    public int? CurrencyId { get; set; }

    public int? RepairKitId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiRepairkitstat? RepairKit { get; set; }
}
