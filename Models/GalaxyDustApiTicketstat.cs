using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTicketstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public string? FileDirection { get; set; }

    public virtual ICollection<GalaxyDustApiAccountticket> GalaxyDustApiAccounttickets { get; set; } = new List<GalaxyDustApiAccountticket>();

    public virtual ICollection<GalaxyDustApiTickettypegroup> GalaxyDustApiTickettypegroups { get; set; } = new List<GalaxyDustApiTickettypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
