using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBagtypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? BagId { get; set; }

    public int? BagTypeId { get; set; }

    public virtual GalaxyDustApiBagstat? Bag { get; set; }

    public virtual GalaxyDustApiBagtype? BagType { get; set; }
}
