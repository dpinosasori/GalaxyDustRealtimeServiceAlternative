using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiShiptypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? ShipId { get; set; }

    public int? ShipTypeId { get; set; }

    public virtual GalaxyDustApiShipstat? Ship { get; set; }

    public virtual GalaxyDustApiShiptype? ShipType { get; set; }
}
