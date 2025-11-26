using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiRepairkitstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double TotalHealth { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public string? Description { get; set; }

    public int? RarityId { get; set; }

    public string? FileDirection { get; set; }

    public virtual ICollection<GalaxyDustApiAccountrepairkit> GalaxyDustApiAccountrepairkits { get; set; } = new List<GalaxyDustApiAccountrepairkit>();

    public virtual ICollection<GalaxyDustApiRepairkitfee> GalaxyDustApiRepairkitfees { get; set; } = new List<GalaxyDustApiRepairkitfee>();

    public virtual ICollection<GalaxyDustApiRepairkittypegroup> GalaxyDustApiRepairkittypegroups { get; set; } = new List<GalaxyDustApiRepairkittypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
