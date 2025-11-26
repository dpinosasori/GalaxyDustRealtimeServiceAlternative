using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccount
{
    public string Password { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime DateJoined { get; set; }

    public Guid Id { get; set; }

    public bool Verified { get; set; }

    public bool RecoveryMode { get; set; }

    public int TokenVersion { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? MetamaskAddress { get; set; }

    public string? Avatar { get; set; }

    public string Lang { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAccountGroup> GalaxyDustApiAccountGroups { get; set; } = new List<GalaxyDustApiAccountGroup>();

    public virtual ICollection<GalaxyDustApiAccountUserPermission> GalaxyDustApiAccountUserPermissions { get; set; } = new List<GalaxyDustApiAccountUserPermission>();

    public virtual ICollection<GalaxyDustApiAccountalliance> GalaxyDustApiAccountalliances { get; set; } = new List<GalaxyDustApiAccountalliance>();

    public virtual ICollection<GalaxyDustApiAccountamirecord> GalaxyDustApiAccountamirecords { get; set; } = new List<GalaxyDustApiAccountamirecord>();

    public virtual ICollection<GalaxyDustApiAccountamistar> GalaxyDustApiAccountamistars { get; set; } = new List<GalaxyDustApiAccountamistar>();

    public virtual ICollection<GalaxyDustApiAccountastrobot> GalaxyDustApiAccountastrobots { get; set; } = new List<GalaxyDustApiAccountastrobot>();

    public virtual ICollection<GalaxyDustApiAccountbadge> GalaxyDustApiAccountbadges { get; set; } = new List<GalaxyDustApiAccountbadge>();

    public virtual ICollection<GalaxyDustApiAccountbag> GalaxyDustApiAccountbags { get; set; } = new List<GalaxyDustApiAccountbag>();

    public virtual ICollection<GalaxyDustApiAccountbanned> GalaxyDustApiAccountbanneds { get; set; } = new List<GalaxyDustApiAccountbanned>();

    public virtual ICollection<GalaxyDustApiAccountblueprint> GalaxyDustApiAccountblueprints { get; set; } = new List<GalaxyDustApiAccountblueprint>();

    public virtual ICollection<GalaxyDustApiAccountcurrency> GalaxyDustApiAccountcurrencies { get; set; } = new List<GalaxyDustApiAccountcurrency>();

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

    public virtual ICollection<GalaxyDustApiActivebuyorder> GalaxyDustApiActivebuyorders { get; set; } = new List<GalaxyDustApiActivebuyorder>();

    public virtual ICollection<GalaxyDustApiAlliance> GalaxyDustApiAlliances { get; set; } = new List<GalaxyDustApiAlliance>();

    public virtual ICollection<GalaxyDustApiAuction> GalaxyDustApiAuctionAccountBiggestBidders { get; set; } = new List<GalaxyDustApiAuction>();

    public virtual ICollection<GalaxyDustApiAuction> GalaxyDustApiAuctionAccounts { get; set; } = new List<GalaxyDustApiAuction>();

    public virtual ICollection<GalaxyDustApiAuctionbid> GalaxyDustApiAuctionbids { get; set; } = new List<GalaxyDustApiAuctionbid>();

    public virtual ICollection<GalaxyDustApiBlockchaininvoice> GalaxyDustApiBlockchaininvoices { get; set; } = new List<GalaxyDustApiBlockchaininvoice>();

    public virtual ICollection<GalaxyDustApiCan> GalaxyDustApiCans { get; set; } = new List<GalaxyDustApiCan>();

    public virtual ICollection<GalaxyDustApiEmailverification> GalaxyDustApiEmailverifications { get; set; } = new List<GalaxyDustApiEmailverification>();

    public virtual ICollection<GalaxyDustApiFleetgroup> GalaxyDustApiFleetgroups { get; set; } = new List<GalaxyDustApiFleetgroup>();

    public virtual ICollection<GalaxyDustApiMarket> GalaxyDustApiMarkets { get; set; } = new List<GalaxyDustApiMarket>();

    public virtual ICollection<GalaxyDustApiMintednft> GalaxyDustApiMintednfts { get; set; } = new List<GalaxyDustApiMintednft>();

    public virtual ICollection<GalaxyDustApiPasswordresettoken> GalaxyDustApiPasswordresettokens { get; set; } = new List<GalaxyDustApiPasswordresettoken>();

    public virtual ICollection<GalaxyDustApiPlanet> GalaxyDustApiPlanetFirstDiscoverers { get; set; } = new List<GalaxyDustApiPlanet>();

    public virtual ICollection<GalaxyDustApiPlanet> GalaxyDustApiPlanetSecondDiscoverers { get; set; } = new List<GalaxyDustApiPlanet>();

    public virtual ICollection<GalaxyDustApiStar> GalaxyDustApiStarFirstDiscoverers { get; set; } = new List<GalaxyDustApiStar>();

    public virtual ICollection<GalaxyDustApiStar> GalaxyDustApiStarSecondDiscoverers { get; set; } = new List<GalaxyDustApiStar>();

    public virtual ICollection<GalaxyDustApiTraveldatum> GalaxyDustApiTraveldata { get; set; } = new List<GalaxyDustApiTraveldatum>();

    public virtual ICollection<GalaxyDustApiTravel> GalaxyDustApiTravels { get; set; } = new List<GalaxyDustApiTravel>();
}
