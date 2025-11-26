using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiLicensetypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? LicenseId { get; set; }

    public int? LicenseTypeId { get; set; }

    public virtual GalaxyDustApiLicensestat? License { get; set; }

    public virtual GalaxyDustApiLicensetype? LicenseType { get; set; }
}
