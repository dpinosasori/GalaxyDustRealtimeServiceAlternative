using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAuctionbid
{
    public int Id { get; set; }

    public double Ammount { get; set; }

    public Guid? AccountId { get; set; }

    public int? AuctionId { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }

    public virtual GalaxyDustApiAuction? Auction { get; set; }
}
