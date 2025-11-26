using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiLicensestat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public double PowerScore { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public int? CollectionId { get; set; }

    public TimeSpan? Duration { get; set; }

    public string? FileDirection { get; set; }

    public int? FreeSpace { get; set; }

    public virtual GalaxyDustApiCollection? Collection { get; set; }

    public virtual ICollection<GalaxyDustApiAccountlicense> GalaxyDustApiAccountlicenses { get; set; } = new List<GalaxyDustApiAccountlicense>();

    public virtual ICollection<GalaxyDustApiFleetgroup> GalaxyDustApiFleetgroups { get; set; } = new List<GalaxyDustApiFleetgroup>();

    public virtual ICollection<GalaxyDustApiLicensetypegroup> GalaxyDustApiLicensetypegroups { get; set; } = new List<GalaxyDustApiLicensetypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
