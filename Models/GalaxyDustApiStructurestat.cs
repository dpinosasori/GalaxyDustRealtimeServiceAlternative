using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStructurestat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public double PowerScore { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? CollectionId { get; set; }

    public int? CompanyId { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public int MaxLevel { get; set; }

    public string? FileDirection { get; set; }

    public virtual GalaxyDustApiCollection? Collection { get; set; }

    public virtual GalaxyDustApiCompany? Company { get; set; }

    public virtual ICollection<GalaxyDustApiAccountstructure> GalaxyDustApiAccountstructures { get; set; } = new List<GalaxyDustApiAccountstructure>();

    public virtual ICollection<GalaxyDustApiStructureleveluprequirement> GalaxyDustApiStructureleveluprequirements { get; set; } = new List<GalaxyDustApiStructureleveluprequirement>();

    public virtual ICollection<GalaxyDustApiStructureskilllevelgroup> GalaxyDustApiStructureskilllevelgroups { get; set; } = new List<GalaxyDustApiStructureskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiStructuretypegroup> GalaxyDustApiStructuretypegroups { get; set; } = new List<GalaxyDustApiStructuretypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
