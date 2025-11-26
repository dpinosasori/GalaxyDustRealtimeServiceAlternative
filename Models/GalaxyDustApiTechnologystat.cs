using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTechnologystat
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

    public virtual ICollection<GalaxyDustApiAccounttechnology> GalaxyDustApiAccounttechnologies { get; set; } = new List<GalaxyDustApiAccounttechnology>();

    public virtual ICollection<GalaxyDustApiTechnologyleveluprequirement> GalaxyDustApiTechnologyleveluprequirements { get; set; } = new List<GalaxyDustApiTechnologyleveluprequirement>();

    public virtual ICollection<GalaxyDustApiTechnologyskilllevelgroup> GalaxyDustApiTechnologyskilllevelgroups { get; set; } = new List<GalaxyDustApiTechnologyskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiTechnologytypegroup> GalaxyDustApiTechnologytypegroups { get; set; } = new List<GalaxyDustApiTechnologytypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
