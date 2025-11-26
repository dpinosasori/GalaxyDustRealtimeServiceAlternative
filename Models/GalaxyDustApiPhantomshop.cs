using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiPhantomshop
{
    public int Id { get; set; }

    public bool Available { get; set; }

    public int? Stock { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid ItemId { get; set; }

    public virtual ICollection<GalaxyDustApiItemprice> GalaxyDustApiItemprices { get; set; } = new List<GalaxyDustApiItemprice>();

    public virtual GalaxyDustApiItem Item { get; set; } = null!;
}
