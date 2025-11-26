using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountpack
{
    public int Id { get; set; }

    public Guid IdToken { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int CanId { get; set; }

    public Guid AccountId { get; set; }

    public int? AuctionId { get; set; }

    public int? MarketId { get; set; }

    public int PackId { get; set; }

    public string? ContractCollection { get; set; }

    public int? IdNft { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual GalaxyDustApiAuction? Auction { get; set; }

    public virtual GalaxyDustApiCan Can { get; set; } = null!;

    public virtual GalaxyDustApiMarket? Market { get; set; }

    public virtual GalaxyDustApiPackstat Pack { get; set; } = null!;
}
