using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAstrobottypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? AstrobotId { get; set; }

    public int? AstrobotTypeId { get; set; }

    public virtual GalaxyDustApiAstrobotstat? Astrobot { get; set; }

    public virtual GalaxyDustApiAstrobottype? AstrobotType { get; set; }
}
