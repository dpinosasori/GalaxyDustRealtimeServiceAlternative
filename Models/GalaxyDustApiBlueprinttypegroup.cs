using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBlueprinttypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? BlueprintId { get; set; }

    public int? BlueprintTypeId { get; set; }

    public virtual GalaxyDustApiBlueprintstat? Blueprint { get; set; }

    public virtual GalaxyDustApiBlueprinttype? BlueprintType { get; set; }
}
