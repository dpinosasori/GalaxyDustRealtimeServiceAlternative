using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAccountalliance
{
    public int Id { get; set; }

    public Guid? AccountId { get; set; }

    public int? AllianceId { get; set; }

    public int? RoleId { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }

    public virtual GalaxyDustApiAlliance? Alliance { get; set; }

    public virtual GalaxyDustApiAlliancerole? Role { get; set; }
}
