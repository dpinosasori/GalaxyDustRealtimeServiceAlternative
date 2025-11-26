using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiMaterializerstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Uses { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public string? UsableOn { get; set; }

    public string? FileDirection { get; set; }

    public virtual ICollection<GalaxyDustApiAccountmaterializer> GalaxyDustApiAccountmaterializers { get; set; } = new List<GalaxyDustApiAccountmaterializer>();

    public virtual ICollection<GalaxyDustApiMaterializertypegroup> GalaxyDustApiMaterializertypegroups { get; set; } = new List<GalaxyDustApiMaterializertypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
