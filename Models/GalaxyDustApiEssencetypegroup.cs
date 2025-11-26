using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiEssencetypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? EssenceId { get; set; }

    public int? EssenceTypeId { get; set; }

    public virtual GalaxyDustApiEssencestat? Essence { get; set; }

    public virtual GalaxyDustApiEssencetype? EssenceType { get; set; }
}
