using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiEngine
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiShipstat> GalaxyDustApiShipstats { get; set; } = new List<GalaxyDustApiShipstat>();
}
