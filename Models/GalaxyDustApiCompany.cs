using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiCompany
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAstrobotstat> GalaxyDustApiAstrobotstats { get; set; } = new List<GalaxyDustApiAstrobotstat>();

    public virtual ICollection<GalaxyDustApiShipstat> GalaxyDustApiShipstats { get; set; } = new List<GalaxyDustApiShipstat>();

    public virtual ICollection<GalaxyDustApiStructurestat> GalaxyDustApiStructurestats { get; set; } = new List<GalaxyDustApiStructurestat>();

    public virtual ICollection<GalaxyDustApiTechnologystat> GalaxyDustApiTechnologystats { get; set; } = new List<GalaxyDustApiTechnologystat>();

    public virtual ICollection<GalaxyDustApiToolstat> GalaxyDustApiToolstats { get; set; } = new List<GalaxyDustApiToolstat>();
}
