using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAuction
{
    public int Id { get; set; }

    public double StartPrice { get; set; }

    public double? BiggestBid { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinalDate { get; set; }

    public int AccountItemId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? AccountBiggestBidderId { get; set; }

    public int? CurrencyId { get; set; }

    public Guid? ItemId { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }

    public virtual GalaxyDustApiAccount? AccountBiggestBidder { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual ICollection<GalaxyDustApiAccountastrobot> GalaxyDustApiAccountastrobots { get; set; } = new List<GalaxyDustApiAccountastrobot>();

    public virtual ICollection<GalaxyDustApiAccountbadge> GalaxyDustApiAccountbadges { get; set; } = new List<GalaxyDustApiAccountbadge>();

    public virtual ICollection<GalaxyDustApiAccountbag> GalaxyDustApiAccountbags { get; set; } = new List<GalaxyDustApiAccountbag>();

    public virtual ICollection<GalaxyDustApiAccountblueprint> GalaxyDustApiAccountblueprints { get; set; } = new List<GalaxyDustApiAccountblueprint>();

    public virtual ICollection<GalaxyDustApiAccountdefense> GalaxyDustApiAccountdefenses { get; set; } = new List<GalaxyDustApiAccountdefense>();

    public virtual ICollection<GalaxyDustApiAccountessence> GalaxyDustApiAccountessences { get; set; } = new List<GalaxyDustApiAccountessence>();

    public virtual ICollection<GalaxyDustApiAccountlicense> GalaxyDustApiAccountlicenses { get; set; } = new List<GalaxyDustApiAccountlicense>();

    public virtual ICollection<GalaxyDustApiAccountmaterializer> GalaxyDustApiAccountmaterializers { get; set; } = new List<GalaxyDustApiAccountmaterializer>();

    public virtual ICollection<GalaxyDustApiAccountpack> GalaxyDustApiAccountpacks { get; set; } = new List<GalaxyDustApiAccountpack>();

    public virtual ICollection<GalaxyDustApiAccountqmp> GalaxyDustApiAccountqmps { get; set; } = new List<GalaxyDustApiAccountqmp>();

    public virtual ICollection<GalaxyDustApiAccountrepairkit> GalaxyDustApiAccountrepairkits { get; set; } = new List<GalaxyDustApiAccountrepairkit>();

    public virtual ICollection<GalaxyDustApiAccountship> GalaxyDustApiAccountships { get; set; } = new List<GalaxyDustApiAccountship>();

    public virtual ICollection<GalaxyDustApiAccountstructure> GalaxyDustApiAccountstructures { get; set; } = new List<GalaxyDustApiAccountstructure>();

    public virtual ICollection<GalaxyDustApiAccounttechnology> GalaxyDustApiAccounttechnologies { get; set; } = new List<GalaxyDustApiAccounttechnology>();

    public virtual ICollection<GalaxyDustApiAccountticket> GalaxyDustApiAccounttickets { get; set; } = new List<GalaxyDustApiAccountticket>();

    public virtual ICollection<GalaxyDustApiAccounttool> GalaxyDustApiAccounttools { get; set; } = new List<GalaxyDustApiAccounttool>();

    public virtual ICollection<GalaxyDustApiAuctionbid> GalaxyDustApiAuctionbids { get; set; } = new List<GalaxyDustApiAuctionbid>();

    public virtual GalaxyDustApiItem? Item { get; set; }
}
