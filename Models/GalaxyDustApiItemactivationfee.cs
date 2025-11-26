using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiItemactivationfee
{
    public int Id { get; set; }

    public double Price { get; set; }

    public int? CurrencyId { get; set; }

    public Guid ItemId { get; set; }

    public int? ItemActivationFeeGroupId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiItem Item { get; set; } = null!;

    public virtual GalaxyDustApiItemactivationfeegroup? ItemActivationFeeGroup { get; set; }
}
