using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDestroyed
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int ShipId { get; set; }

    public Guid? StelarBodyId { get; set; }

    public virtual ICollection<GalaxyDustApiAccountship> GalaxyDustApiAccountships { get; set; } = new List<GalaxyDustApiAccountship>();

    public virtual GalaxyDustApiShipstat Ship { get; set; } = null!;

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
