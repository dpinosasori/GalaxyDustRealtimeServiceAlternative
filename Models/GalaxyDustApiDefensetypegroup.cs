using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDefensetypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? DefenseId { get; set; }

    public int? DefenseTypeId { get; set; }

    public virtual GalaxyDustApiDefensestat? Defense { get; set; }

    public virtual GalaxyDustApiDefensetype? DefenseType { get; set; }
}
