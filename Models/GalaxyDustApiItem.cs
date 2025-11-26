using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiItem
{
    public Guid Id { get; set; }

    public string RelatedName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsNft { get; set; }

    public int? ItemActivationFeeGroupId { get; set; }

    public int? ItemTypeId { get; set; }

    public bool? MarketEnabled { get; set; }

    public int? ItemCategoryId { get; set; }

    public virtual GalaxyDustApiAstrobotstat? GalaxyDustApiAstrobotstat { get; set; }

    public virtual ICollection<GalaxyDustApiAuction> GalaxyDustApiAuctions { get; set; } = new List<GalaxyDustApiAuction>();

    public virtual GalaxyDustApiBadgestat? GalaxyDustApiBadgestat { get; set; }

    public virtual ICollection<GalaxyDustApiBagreward> GalaxyDustApiBagrewards { get; set; } = new List<GalaxyDustApiBagreward>();

    public virtual GalaxyDustApiBagstat? GalaxyDustApiBagstat { get; set; }

    public virtual ICollection<GalaxyDustApiBlockchaininvoice> GalaxyDustApiBlockchaininvoices { get; set; } = new List<GalaxyDustApiBlockchaininvoice>();

    public virtual ICollection<GalaxyDustApiBlueprintrequirement> GalaxyDustApiBlueprintrequirements { get; set; } = new List<GalaxyDustApiBlueprintrequirement>();

    public virtual ICollection<GalaxyDustApiBlueprintstat> GalaxyDustApiBlueprintstatBlueprintResultItems { get; set; } = new List<GalaxyDustApiBlueprintstat>();

    public virtual GalaxyDustApiBlueprintstat? GalaxyDustApiBlueprintstatItem { get; set; }

    public virtual GalaxyDustApiDefensestat? GalaxyDustApiDefensestat { get; set; }

    public virtual ICollection<GalaxyDustApiDiscoverlimitedrewardstatitem> GalaxyDustApiDiscoverlimitedrewardstatitems { get; set; } = new List<GalaxyDustApiDiscoverlimitedrewardstatitem>();

    public virtual ICollection<GalaxyDustApiDiscoverrewardstatitem> GalaxyDustApiDiscoverrewardstatitems { get; set; } = new List<GalaxyDustApiDiscoverrewardstatitem>();

    public virtual GalaxyDustApiEssencestat? GalaxyDustApiEssencestat { get; set; }

    public virtual ICollection<GalaxyDustApiFirstglobaldiscoverrewardstatitem> GalaxyDustApiFirstglobaldiscoverrewardstatitems { get; set; } = new List<GalaxyDustApiFirstglobaldiscoverrewardstatitem>();

    public virtual ICollection<GalaxyDustApiFleeteventitem> GalaxyDustApiFleeteventitems { get; set; } = new List<GalaxyDustApiFleeteventitem>();

    public virtual ICollection<GalaxyDustApiFlyrequirement> GalaxyDustApiFlyrequirements { get; set; } = new List<GalaxyDustApiFlyrequirement>();

    public virtual ICollection<GalaxyDustApiItemactivationfee> GalaxyDustApiItemactivationfees { get; set; } = new List<GalaxyDustApiItemactivationfee>();

    public virtual ICollection<GalaxyDustApiItemastrobotleveluprequirement> GalaxyDustApiItemastrobotleveluprequirements { get; set; } = new List<GalaxyDustApiItemastrobotleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItembadgeleveluprequirement> GalaxyDustApiItembadgeleveluprequirements { get; set; } = new List<GalaxyDustApiItembadgeleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemdefenseleveluprequirement> GalaxyDustApiItemdefenseleveluprequirements { get; set; } = new List<GalaxyDustApiItemdefenseleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemshipleveluprequirement> GalaxyDustApiItemshipleveluprequirements { get; set; } = new List<GalaxyDustApiItemshipleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemstructureleveluprequirement> GalaxyDustApiItemstructureleveluprequirements { get; set; } = new List<GalaxyDustApiItemstructureleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemtechnologyleveluprequirement> GalaxyDustApiItemtechnologyleveluprequirements { get; set; } = new List<GalaxyDustApiItemtechnologyleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemtoolleveluprequirement> GalaxyDustApiItemtoolleveluprequirements { get; set; } = new List<GalaxyDustApiItemtoolleveluprequirement>();

    public virtual GalaxyDustApiLicensestat? GalaxyDustApiLicensestat { get; set; }

    public virtual ICollection<GalaxyDustApiMarket> GalaxyDustApiMarkets { get; set; } = new List<GalaxyDustApiMarket>();

    public virtual GalaxyDustApiMaterializerstat? GalaxyDustApiMaterializerstat { get; set; }

    public virtual ICollection<GalaxyDustApiMintednft> GalaxyDustApiMintednfts { get; set; } = new List<GalaxyDustApiMintednft>();

    public virtual ICollection<GalaxyDustApiNftshop> GalaxyDustApiNftshops { get; set; } = new List<GalaxyDustApiNftshop>();

    public virtual ICollection<GalaxyDustApiPackreward> GalaxyDustApiPackrewards { get; set; } = new List<GalaxyDustApiPackreward>();

    public virtual GalaxyDustApiPackstat? GalaxyDustApiPackstat { get; set; }

    public virtual ICollection<GalaxyDustApiPhantomshop> GalaxyDustApiPhantomshops { get; set; } = new List<GalaxyDustApiPhantomshop>();

    public virtual GalaxyDustApiQmpstat? GalaxyDustApiQmpstat { get; set; }

    public virtual GalaxyDustApiRepairkitstat? GalaxyDustApiRepairkitstat { get; set; }

    public virtual GalaxyDustApiShipstat? GalaxyDustApiShipstat { get; set; }

    public virtual ICollection<GalaxyDustApiSkillrequirement> GalaxyDustApiSkillrequirements { get; set; } = new List<GalaxyDustApiSkillrequirement>();

    public virtual GalaxyDustApiStructurestat? GalaxyDustApiStructurestat { get; set; }

    public virtual GalaxyDustApiTechnologystat? GalaxyDustApiTechnologystat { get; set; }

    public virtual GalaxyDustApiTicketstat? GalaxyDustApiTicketstat { get; set; }

    public virtual GalaxyDustApiToolstat? GalaxyDustApiToolstat { get; set; }

    public virtual ICollection<GalaxyDustApiXenogonitemreward> GalaxyDustApiXenogonitemrewards { get; set; } = new List<GalaxyDustApiXenogonitemreward>();

    public virtual GalaxyDustApiItemactivationfeegroup? ItemActivationFeeGroup { get; set; }

    public virtual GalaxyDustApiItemcategory? ItemCategory { get; set; }

    public virtual GalaxyDustApiItemtype? ItemType { get; set; }
}
