using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiMintednft
{
    public int Id { get; set; }

    public string? Rarity { get; set; }

    public List<string> Type { get; set; } = null!;

    public int? Quantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? ItemId { get; set; }

    public int? Level { get; set; }

    public string? TxHash { get; set; }

    public string? Name { get; set; }

    public Guid? AccountToId { get; set; }

    public string? FileDirection { get; set; }

    public string? DataItem { get; set; }

    public virtual GalaxyDustApiAccount? AccountTo { get; set; }

    public virtual GalaxyDustApiItem? Item { get; set; }
}
