using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStructuretypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? StructureId { get; set; }

    public int? StructureTypeId { get; set; }

    public virtual GalaxyDustApiStructurestat? Structure { get; set; }

    public virtual GalaxyDustApiStructuretype? StructureType { get; set; }
}
