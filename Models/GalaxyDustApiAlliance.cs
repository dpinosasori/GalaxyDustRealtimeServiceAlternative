using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAlliance
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? AllianceOwnerId { get; set; }

    public int? RankId { get; set; }

    public virtual GalaxyDustApiAccount? AllianceOwner { get; set; }

    public virtual ICollection<GalaxyDustApiAccountalliance> GalaxyDustApiAccountalliances { get; set; } = new List<GalaxyDustApiAccountalliance>();

    public virtual ICollection<GalaxyDustApiAlliancedeposit> GalaxyDustApiAlliancedeposits { get; set; } = new List<GalaxyDustApiAlliancedeposit>();

    public virtual ICollection<GalaxyDustApiAllianceplanet> GalaxyDustApiAllianceplanets { get; set; } = new List<GalaxyDustApiAllianceplanet>();

    public virtual GalaxyDustApiAlliancerank? Rank { get; set; }
}
