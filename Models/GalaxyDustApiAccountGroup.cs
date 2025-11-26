using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountGroup
{
    public long Id { get; set; }

    public Guid AccountId { get; set; }

    public int GroupId { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual AuthGroup Group { get; set; } = null!;
}
