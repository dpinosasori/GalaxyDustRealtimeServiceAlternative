using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiMaterializertypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? MaterializerId { get; set; }

    public int? MaterializerTypeId { get; set; }

    public virtual GalaxyDustApiMaterializerstat? Materializer { get; set; }

    public virtual GalaxyDustApiMaterializertype? MaterializerType { get; set; }
}
