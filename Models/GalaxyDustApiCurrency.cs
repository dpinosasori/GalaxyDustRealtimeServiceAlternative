using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiCurrency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Icon { get; set; }

    public virtual ICollection<GalaxyDustApiAccountcurrency> GalaxyDustApiAccountcurrencies { get; set; } = new List<GalaxyDustApiAccountcurrency>();

    public virtual ICollection<GalaxyDustApiAlliancedeposit> GalaxyDustApiAlliancedeposits { get; set; } = new List<GalaxyDustApiAlliancedeposit>();

    public virtual ICollection<GalaxyDustApiAuction> GalaxyDustApiAuctions { get; set; } = new List<GalaxyDustApiAuction>();

    public virtual ICollection<GalaxyDustApiBagreward> GalaxyDustApiBagrewards { get; set; } = new List<GalaxyDustApiBagreward>();

    public virtual ICollection<GalaxyDustApiBlockchaininvoice> GalaxyDustApiBlockchaininvoices { get; set; } = new List<GalaxyDustApiBlockchaininvoice>();

    public virtual ICollection<GalaxyDustApiBlueprintrequirement> GalaxyDustApiBlueprintrequirements { get; set; } = new List<GalaxyDustApiBlueprintrequirement>();

    public virtual ICollection<GalaxyDustApiCancurrencycapacity> GalaxyDustApiCancurrencycapacities { get; set; } = new List<GalaxyDustApiCancurrencycapacity>();

    public virtual ICollection<GalaxyDustApiCansafedeposit> GalaxyDustApiCansafedeposits { get; set; } = new List<GalaxyDustApiCansafedeposit>();

    public virtual ICollection<GalaxyDustApiCurrencyastrobotleveluprequirement> GalaxyDustApiCurrencyastrobotleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencyastrobotleveluprequirement>();

    public virtual ICollection<GalaxyDustApiCurrencybadgeleveluprequirement> GalaxyDustApiCurrencybadgeleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencybadgeleveluprequirement>();

    public virtual ICollection<GalaxyDustApiCurrencydefenseleveluprequirement> GalaxyDustApiCurrencydefenseleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencydefenseleveluprequirement>();

    public virtual ICollection<GalaxyDustApiCurrencyshipleveluprequirement> GalaxyDustApiCurrencyshipleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencyshipleveluprequirement>();

    public virtual ICollection<GalaxyDustApiCurrencystructureleveluprequirement> GalaxyDustApiCurrencystructureleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencystructureleveluprequirement>();

    public virtual ICollection<GalaxyDustApiCurrencytechnologyleveluprequirement> GalaxyDustApiCurrencytechnologyleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencytechnologyleveluprequirement>();

    public virtual ICollection<GalaxyDustApiCurrencytoolleveluprequirement> GalaxyDustApiCurrencytoolleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencytoolleveluprequirement>();

    public virtual ICollection<GalaxyDustApiDiscoverlimitedrewardstatcurrency> GalaxyDustApiDiscoverlimitedrewardstatcurrencies { get; set; } = new List<GalaxyDustApiDiscoverlimitedrewardstatcurrency>();

    public virtual ICollection<GalaxyDustApiDiscoverrewardstatcurrency> GalaxyDustApiDiscoverrewardstatcurrencies { get; set; } = new List<GalaxyDustApiDiscoverrewardstatcurrency>();

    public virtual ICollection<GalaxyDustApiFirstglobaldiscoverrewardstatcurrency> GalaxyDustApiFirstglobaldiscoverrewardstatcurrencies { get; set; } = new List<GalaxyDustApiFirstglobaldiscoverrewardstatcurrency>();

    public virtual ICollection<GalaxyDustApiFleeteventcurrency> GalaxyDustApiFleeteventcurrencies { get; set; } = new List<GalaxyDustApiFleeteventcurrency>();

    public virtual ICollection<GalaxyDustApiGalaxyclustermaxresource> GalaxyDustApiGalaxyclustermaxresources { get; set; } = new List<GalaxyDustApiGalaxyclustermaxresource>();

    public virtual ICollection<GalaxyDustApiItemactivationfee> GalaxyDustApiItemactivationfees { get; set; } = new List<GalaxyDustApiItemactivationfee>();

    public virtual ICollection<GalaxyDustApiItemprice> GalaxyDustApiItemprices { get; set; } = new List<GalaxyDustApiItemprice>();

    public virtual ICollection<GalaxyDustApiItempricesnft> GalaxyDustApiItempricesnfts { get; set; } = new List<GalaxyDustApiItempricesnft>();

    public virtual ICollection<GalaxyDustApiMarket> GalaxyDustApiMarkets { get; set; } = new List<GalaxyDustApiMarket>();

    public virtual ICollection<GalaxyDustApiPackreward> GalaxyDustApiPackrewards { get; set; } = new List<GalaxyDustApiPackreward>();

    public virtual ICollection<GalaxyDustApiRepairkitfee> GalaxyDustApiRepairkitfees { get; set; } = new List<GalaxyDustApiRepairkitfee>();

    public virtual ICollection<GalaxyDustApiSkillrequirement> GalaxyDustApiSkillrequirements { get; set; } = new List<GalaxyDustApiSkillrequirement>();

    public virtual ICollection<GalaxyDustApiXenogoncurrencyreward> GalaxyDustApiXenogoncurrencyrewards { get; set; } = new List<GalaxyDustApiXenogoncurrencyreward>();
}
