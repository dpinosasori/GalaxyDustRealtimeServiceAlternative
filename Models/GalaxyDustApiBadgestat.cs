using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBadgestat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double PowerScore { get; set; }

    public int MaxStack { get; set; }

    public int? CollectionId { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public int MaxLevel { get; set; }

    public TimeSpan? Duration { get; set; }

    public bool IsPermanent { get; set; }

    public int BadgeSlots { get; set; }

    public string? FileDirection { get; set; }

    public virtual GalaxyDustApiCollection? Collection { get; set; }

    public virtual ICollection<GalaxyDustApiAccountbadge> GalaxyDustApiAccountbadges { get; set; } = new List<GalaxyDustApiAccountbadge>();

    public virtual ICollection<GalaxyDustApiBadgeleveluprequirement> GalaxyDustApiBadgeleveluprequirements { get; set; } = new List<GalaxyDustApiBadgeleveluprequirement>();

    public virtual ICollection<GalaxyDustApiBadgeskilllevelgroup> GalaxyDustApiBadgeskilllevelgroups { get; set; } = new List<GalaxyDustApiBadgeskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiBadgetypegroup> GalaxyDustApiBadgetypegroups { get; set; } = new List<GalaxyDustApiBadgetypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
