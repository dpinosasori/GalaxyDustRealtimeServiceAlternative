using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountUserPermission
{
    public long Id { get; set; }

    public Guid AccountId { get; set; }

    public int PermissionId { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual AuthPermission Permission { get; set; } = null!;
}
