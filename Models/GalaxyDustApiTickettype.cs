using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTickettype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiTickettypegroup> GalaxyDustApiTickettypegroups { get; set; } = new List<GalaxyDustApiTickettypegroup>();
}
