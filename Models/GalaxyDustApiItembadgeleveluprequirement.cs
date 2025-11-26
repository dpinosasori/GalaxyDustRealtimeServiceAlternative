using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiItembadgeleveluprequirement
{
    public long Id { get; set; }

    public int ItemLevel { get; set; }

    public bool? IsBurnable { get; set; }

    public Guid ItemId { get; set; }

    public int RequirementId { get; set; }

    public virtual GalaxyDustApiItem Item { get; set; } = null!;

    public virtual GalaxyDustApiBadgeleveluprequirement Requirement { get; set; } = null!;
}
