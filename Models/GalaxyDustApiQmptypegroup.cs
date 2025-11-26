using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiQmptypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? QmpId { get; set; }

    public int? QmpTypeId { get; set; }

    public virtual GalaxyDustApiQmpstat? Qmp { get; set; }

    public virtual GalaxyDustApiQmptype? QmpType { get; set; }
}
