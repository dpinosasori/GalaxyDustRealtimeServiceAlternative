using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBlueprintstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int MaxUses { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? BlueprintResultItemId { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public double? Percentage { get; set; }

    public bool? IsRandom { get; set; }

    public int? ItemTypeId { get; set; }

    public List<string> RarityNames { get; set; } = null!;

    public TimeSpan? CreateDuration { get; set; }

    public string? FileDirection { get; set; }

    public virtual GalaxyDustApiItem? BlueprintResultItem { get; set; }

    public virtual ICollection<GalaxyDustApiAccountblueprint> GalaxyDustApiAccountblueprints { get; set; } = new List<GalaxyDustApiAccountblueprint>();

    public virtual ICollection<GalaxyDustApiBlueprintrequirement> GalaxyDustApiBlueprintrequirements { get; set; } = new List<GalaxyDustApiBlueprintrequirement>();

    public virtual ICollection<GalaxyDustApiBlueprinttypegroup> GalaxyDustApiBlueprinttypegroups { get; set; } = new List<GalaxyDustApiBlueprinttypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiItemtype? ItemType { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
