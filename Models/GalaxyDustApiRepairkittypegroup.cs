using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiRepairkittypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? RepairKitId { get; set; }

    public int? RepairKitTypeId { get; set; }

    public virtual GalaxyDustApiRepairkitstat? RepairKit { get; set; }

    public virtual GalaxyDustApiRepairkittype? RepairKitType { get; set; }
}
