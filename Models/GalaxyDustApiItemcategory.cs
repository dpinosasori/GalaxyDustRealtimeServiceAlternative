using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiItemcategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAstrobotcategorylevelrequirement> GalaxyDustApiAstrobotcategorylevelrequirements { get; set; } = new List<GalaxyDustApiAstrobotcategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiBadgecategorylevelrequirement> GalaxyDustApiBadgecategorylevelrequirements { get; set; } = new List<GalaxyDustApiBadgecategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiBlueprintrequirement> GalaxyDustApiBlueprintrequirements { get; set; } = new List<GalaxyDustApiBlueprintrequirement>();

    public virtual ICollection<GalaxyDustApiDefensecategorylevelrequirement> GalaxyDustApiDefensecategorylevelrequirements { get; set; } = new List<GalaxyDustApiDefensecategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiItem> GalaxyDustApiItems { get; set; } = new List<GalaxyDustApiItem>();

    public virtual ICollection<GalaxyDustApiShipcategorylevelrequirement> GalaxyDustApiShipcategorylevelrequirements { get; set; } = new List<GalaxyDustApiShipcategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiStructurecategorylevelrequirement> GalaxyDustApiStructurecategorylevelrequirements { get; set; } = new List<GalaxyDustApiStructurecategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiTechnologycategorylevelrequirement> GalaxyDustApiTechnologycategorylevelrequirements { get; set; } = new List<GalaxyDustApiTechnologycategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiToolcategorylevelrequirement> GalaxyDustApiToolcategorylevelrequirements { get; set; } = new List<GalaxyDustApiToolcategorylevelrequirement>();
}
