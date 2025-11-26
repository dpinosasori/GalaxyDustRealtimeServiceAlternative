using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiToolstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public double PowerScore { get; set; }

    public double FleetSpace { get; set; }

    public double Durability { get; set; }

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

    public virtual ICollection<GalaxyDustApiAccounttool> GalaxyDustApiAccounttools { get; set; } = new List<GalaxyDustApiAccounttool>();

    public virtual ICollection<GalaxyDustApiToolleveluprequirement> GalaxyDustApiToolleveluprequirements { get; set; } = new List<GalaxyDustApiToolleveluprequirement>();

    public virtual ICollection<GalaxyDustApiToolskilllevelgroup> GalaxyDustApiToolskilllevelgroups { get; set; } = new List<GalaxyDustApiToolskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiTooltypegroup> GalaxyDustApiTooltypegroups { get; set; } = new List<GalaxyDustApiTooltypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
