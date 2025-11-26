using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiItempricesnft
{
    public int Id { get; set; }

    public double Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? CurrencyId { get; set; }

    public int? NftShopId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiNftshop? NftShop { get; set; }
}
