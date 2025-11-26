using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiNftshop
{
    public int Id { get; set; }

    public bool Available { get; set; }

    public int? Stock { get; set; }

    public double Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid ItemId { get; set; }

    public string? ItemType { get; set; }

    public virtual ICollection<GalaxyDustApiItempricesnft> GalaxyDustApiItempricesnfts { get; set; } = new List<GalaxyDustApiItempricesnft>();

    public virtual GalaxyDustApiItem Item { get; set; } = null!;
}
