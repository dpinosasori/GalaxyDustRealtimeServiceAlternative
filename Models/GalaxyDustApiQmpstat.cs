using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiQmpstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int MaxUses { get; set; }

    public Guid? ItemId { get; set; }

    public string? Description { get; set; }

    public int? RarityId { get; set; }

    public string? FileDirection { get; set; }

    public double? PercentageToFindDestroyedShips { get; set; }

    public virtual ICollection<GalaxyDustApiAccountqmp> GalaxyDustApiAccountqmps { get; set; } = new List<GalaxyDustApiAccountqmp>();

    public virtual ICollection<GalaxyDustApiQmptypegroup> GalaxyDustApiQmptypegroups { get; set; } = new List<GalaxyDustApiQmptypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
