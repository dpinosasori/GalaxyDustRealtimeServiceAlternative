using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFleetgroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid AccountId { get; set; }

    public int? LicenseId { get; set; }

    public int? FreeSpace { get; set; }

    public int? UsedSpace { get; set; }

    public string? Name { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAccountastrobot> GalaxyDustApiAccountastrobots { get; set; } = new List<GalaxyDustApiAccountastrobot>();

    public virtual ICollection<GalaxyDustApiAccountship> GalaxyDustApiAccountships { get; set; } = new List<GalaxyDustApiAccountship>();

    public virtual ICollection<GalaxyDustApiAccounttool> GalaxyDustApiAccounttools { get; set; } = new List<GalaxyDustApiAccounttool>();

    public virtual ICollection<GalaxyDustApiFleetaccountactiveskill> GalaxyDustApiFleetaccountactiveskills { get; set; } = new List<GalaxyDustApiFleetaccountactiveskill>();

    public virtual GalaxyDustApiLicensestat? License { get; set; }
}
