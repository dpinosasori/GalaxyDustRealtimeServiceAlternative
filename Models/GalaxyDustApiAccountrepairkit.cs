using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountrepairkit
{
    public int Id { get; set; }

    public Guid IdToken { get; set; }

    public double Health { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CanId { get; set; }

    public Guid AccountId { get; set; }

    public int RepairKitId { get; set; }

    public int? AuctionId { get; set; }

    public int? MarketId { get; set; }

    public string? ContractCollection { get; set; }

    public int? IdNft { get; set; }

    public bool OnAir { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual GalaxyDustApiAuction? Auction { get; set; }

    public virtual GalaxyDustApiCan Can { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiTraveldatum> GalaxyDustApiTraveldata { get; set; } = new List<GalaxyDustApiTraveldatum>();

    public virtual GalaxyDustApiMarket? Market { get; set; }

    public virtual GalaxyDustApiRepairkitstat RepairKit { get; set; } = null!;
}
