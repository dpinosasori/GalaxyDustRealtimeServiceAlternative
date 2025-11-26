using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class AuthGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; } = new List<AuthGroupPermission>();

    public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; } = new List<AuthUserGroup>();

    public virtual ICollection<GalaxyDustApiAccountGroup> GalaxyDustApiAccountGroups { get; set; } = new List<GalaxyDustApiAccountGroup>();
}
