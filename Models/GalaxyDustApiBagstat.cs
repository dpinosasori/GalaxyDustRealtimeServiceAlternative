using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBagstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Message { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public int? EventId { get; set; }

    public int? RarityId { get; set; }

    public string? FileDirection { get; set; }

    public virtual GalaxyDustApiEvent? Event { get; set; }

    public virtual ICollection<GalaxyDustApiAccountbag> GalaxyDustApiAccountbags { get; set; } = new List<GalaxyDustApiAccountbag>();

    public virtual ICollection<GalaxyDustApiBagreward> GalaxyDustApiBagrewards { get; set; } = new List<GalaxyDustApiBagreward>();

    public virtual ICollection<GalaxyDustApiBagtypegroup> GalaxyDustApiBagtypegroups { get; set; } = new List<GalaxyDustApiBagtypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
