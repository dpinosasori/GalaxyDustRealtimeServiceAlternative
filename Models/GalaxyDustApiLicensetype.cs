using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiLicensetype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiLicensetypegroup> GalaxyDustApiLicensetypegroups { get; set; } = new List<GalaxyDustApiLicensetypegroup>();
}
