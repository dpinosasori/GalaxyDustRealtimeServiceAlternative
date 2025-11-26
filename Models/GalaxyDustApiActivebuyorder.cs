using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiActivebuyorder
{
    public int Id { get; set; }

    public double Amount { get; set; }

    public Guid? AccountId { get; set; }

    public int? MarketId { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }

    public virtual GalaxyDustApiMarket? Market { get; set; }
}
