using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAstrobotstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public double TotalHealth { get; set; }

    public double Shield { get; set; }

    public double Defense { get; set; }

    public double KineticAttack { get; set; }

    public double IonAttack { get; set; }

    public double LaserAttack { get; set; }

    public double PlasmaAttack { get; set; }

    public double GravitonAttack { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double PowerScore { get; set; }

    public int? AstrobotSizeId { get; set; }

    public int? CollectionId { get; set; }

    public int? CompanyId { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public int MaxLevel { get; set; }

    public string? FileDirection { get; set; }

    public virtual GalaxyDustApiAstrobotsize? AstrobotSize { get; set; }

    public virtual GalaxyDustApiCollection? Collection { get; set; }

    public virtual GalaxyDustApiCompany? Company { get; set; }

    public virtual ICollection<GalaxyDustApiAccountastrobot> GalaxyDustApiAccountastrobots { get; set; } = new List<GalaxyDustApiAccountastrobot>();

    public virtual ICollection<GalaxyDustApiAstrobotleveluprequirement> GalaxyDustApiAstrobotleveluprequirements { get; set; } = new List<GalaxyDustApiAstrobotleveluprequirement>();

    public virtual ICollection<GalaxyDustApiAstrobotskilllevelgroup> GalaxyDustApiAstrobotskilllevelgroups { get; set; } = new List<GalaxyDustApiAstrobotskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiAstrobottypegroup> GalaxyDustApiAstrobottypegroups { get; set; } = new List<GalaxyDustApiAstrobottypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
