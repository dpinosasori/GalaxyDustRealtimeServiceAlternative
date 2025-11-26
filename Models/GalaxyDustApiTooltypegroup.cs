using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTooltypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? ToolId { get; set; }

    public int? ToolTypeId { get; set; }

    public virtual GalaxyDustApiToolstat? Tool { get; set; }

    public virtual GalaxyDustApiTooltype? ToolType { get; set; }
}
