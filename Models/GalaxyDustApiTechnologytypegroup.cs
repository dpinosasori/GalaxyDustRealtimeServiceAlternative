using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTechnologytypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? TechnologyId { get; set; }

    public int? TechnologyTypeId { get; set; }

    public virtual GalaxyDustApiTechnologystat? Technology { get; set; }

    public virtual GalaxyDustApiTechnologytype? TechnologyType { get; set; }
}
