using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiPacktypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? PackId { get; set; }

    public int? PackTypeId { get; set; }

    public virtual GalaxyDustApiPackstat? Pack { get; set; }

    public virtual GalaxyDustApiPacktype? PackType { get; set; }
}
