using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiRaritytype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiAstrobotstat> GalaxyDustApiAstrobotstats { get; set; } = new List<GalaxyDustApiAstrobotstat>();

    public virtual ICollection<GalaxyDustApiBadgestat> GalaxyDustApiBadgestats { get; set; } = new List<GalaxyDustApiBadgestat>();

    public virtual ICollection<GalaxyDustApiBagstat> GalaxyDustApiBagstats { get; set; } = new List<GalaxyDustApiBagstat>();

    public virtual ICollection<GalaxyDustApiBlueprintstat> GalaxyDustApiBlueprintstats { get; set; } = new List<GalaxyDustApiBlueprintstat>();

    public virtual ICollection<GalaxyDustApiDefensestat> GalaxyDustApiDefensestats { get; set; } = new List<GalaxyDustApiDefensestat>();

    public virtual ICollection<GalaxyDustApiEssencestat> GalaxyDustApiEssencestats { get; set; } = new List<GalaxyDustApiEssencestat>();

    public virtual ICollection<GalaxyDustApiLicensestat> GalaxyDustApiLicensestats { get; set; } = new List<GalaxyDustApiLicensestat>();

    public virtual ICollection<GalaxyDustApiMaterializerstat> GalaxyDustApiMaterializerstats { get; set; } = new List<GalaxyDustApiMaterializerstat>();

    public virtual ICollection<GalaxyDustApiPackstat> GalaxyDustApiPackstats { get; set; } = new List<GalaxyDustApiPackstat>();

    public virtual ICollection<GalaxyDustApiQmpstat> GalaxyDustApiQmpstats { get; set; } = new List<GalaxyDustApiQmpstat>();

    public virtual ICollection<GalaxyDustApiRepairkitstat> GalaxyDustApiRepairkitstats { get; set; } = new List<GalaxyDustApiRepairkitstat>();

    public virtual ICollection<GalaxyDustApiShipstat> GalaxyDustApiShipstats { get; set; } = new List<GalaxyDustApiShipstat>();

    public virtual ICollection<GalaxyDustApiStructurestat> GalaxyDustApiStructurestats { get; set; } = new List<GalaxyDustApiStructurestat>();

    public virtual ICollection<GalaxyDustApiTechnologystat> GalaxyDustApiTechnologystats { get; set; } = new List<GalaxyDustApiTechnologystat>();

    public virtual ICollection<GalaxyDustApiTicketstat> GalaxyDustApiTicketstats { get; set; } = new List<GalaxyDustApiTicketstat>();

    public virtual ICollection<GalaxyDustApiToolstat> GalaxyDustApiToolstats { get; set; } = new List<GalaxyDustApiToolstat>();
}
