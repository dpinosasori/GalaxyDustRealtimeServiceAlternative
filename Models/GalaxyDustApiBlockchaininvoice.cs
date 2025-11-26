using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBlockchaininvoice
{
    public int Id { get; set; }

    public double? CurrencyAmount { get; set; }

    public int? ItemQuantity { get; set; }

    public string? Description { get; set; }

    public string? TransactionHash { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? AccountId { get; set; }

    public int? CurrencyId { get; set; }

    public Guid? ItemId { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiItem? Item { get; set; }
}
