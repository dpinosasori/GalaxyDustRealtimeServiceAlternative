using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiEssencestat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public string? FileDirection { get; set; }

    public virtual ICollection<GalaxyDustApiAccountessence> GalaxyDustApiAccountessences { get; set; } = new List<GalaxyDustApiAccountessence>();

    public virtual ICollection<GalaxyDustApiEssencetypegroup> GalaxyDustApiEssencetypegroups { get; set; } = new List<GalaxyDustApiEssencetypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
