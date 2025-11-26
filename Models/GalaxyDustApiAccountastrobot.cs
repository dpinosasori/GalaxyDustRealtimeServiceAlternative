using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountastrobot
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public Guid IdToken { get; set; }

    public double Health { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? CanId { get; set; }

    public Guid AccountId { get; set; }

    public int AstrobotId { get; set; }

    public int? AuctionId { get; set; }

    public int? MarketId { get; set; }

    public double Experience { get; set; }

    public int Level { get; set; }

    public string? ContractCollection { get; set; }

    public int? IdNft { get; set; }

    public int? FleetGroupId { get; set; }

    public bool OnAir { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual GalaxyDustApiAstrobotstat Astrobot { get; set; } = null!;

    public virtual GalaxyDustApiAuction? Auction { get; set; }

    public virtual GalaxyDustApiCan? Can { get; set; }

    public virtual GalaxyDustApiFleetgroup? FleetGroup { get; set; }

    public virtual GalaxyDustApiMarket? Market { get; set; }
}
