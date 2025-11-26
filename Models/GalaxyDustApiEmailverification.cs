using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiEmailverification
{
    public long Id { get; set; }

    public string Token { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public Guid AccountId { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;
}
