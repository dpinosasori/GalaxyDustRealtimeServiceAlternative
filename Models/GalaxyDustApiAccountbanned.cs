using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountbanned
{
    public int Id { get; set; }

    public string Reason { get; set; } = null!;

    public DateTime DateFrom { get; set; }

    public DateTime? DateUntil { get; set; }

    public Guid AccountId { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;
}
