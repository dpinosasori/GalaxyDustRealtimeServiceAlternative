using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiPackstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public string? FileDirection { get; set; }

    public virtual ICollection<GalaxyDustApiAccountpack> GalaxyDustApiAccountpacks { get; set; } = new List<GalaxyDustApiAccountpack>();

    public virtual ICollection<GalaxyDustApiPackreward> GalaxyDustApiPackrewards { get; set; } = new List<GalaxyDustApiPackreward>();

    public virtual ICollection<GalaxyDustApiPacktypegroup> GalaxyDustApiPacktypegroups { get; set; } = new List<GalaxyDustApiPacktypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
