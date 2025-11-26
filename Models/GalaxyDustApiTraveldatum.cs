using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTraveldatum
{
    public int Id { get; set; }

    public Guid AccountId { get; set; }

    public int TravelId { get; set; }

    public string? Task { get; set; }

    public List<string>? AccountAstrobots { get; set; }

    public List<string>? AccountAstrobotsInGroups { get; set; }

    public List<string>? AccountShips { get; set; }

    public List<string>? AccountShipsInGroups { get; set; }

    public double? Percentage { get; set; }

    public int? RepairKitToUseId { get; set; }

    public DateTime? StartTime { get; set; }

    public double? TotalTime { get; set; }

    public int? QmpToUseId { get; set; }

    public double? FleetCargo { get; set; }

    public double? FleetHealth { get; set; }

    public double? FleetSpeed { get; set; }

    public int? ToolToUseId { get; set; }

    public string? Coords { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual GalaxyDustApiAccountqmp? QmpToUse { get; set; }

    public virtual GalaxyDustApiAccountrepairkit? RepairKitToUse { get; set; }

    public virtual GalaxyDustApiAccounttool? ToolToUse { get; set; }

    public virtual GalaxyDustApiTravel Travel { get; set; } = null!;
}
