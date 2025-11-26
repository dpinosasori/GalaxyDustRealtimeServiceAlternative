using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFlyrequirement
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ItemLevel { get; set; }

    public Guid? ItemId { get; set; }

    public Guid? StelarBodyId { get; set; }

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
