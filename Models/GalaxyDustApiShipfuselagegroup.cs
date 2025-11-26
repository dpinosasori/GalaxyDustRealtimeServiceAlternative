using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiShipfuselagegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? FuselageId { get; set; }

    public int? ShipId { get; set; }

    public virtual GalaxyDustApiFuselage? Fuselage { get; set; }

    public virtual GalaxyDustApiShipstat? Ship { get; set; }
}
