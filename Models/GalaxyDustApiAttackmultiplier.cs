using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAttackmultiplier
{
    public int Id { get; set; }

    public string? AttackType { get; set; }

    public double Multiplier { get; set; }
}
