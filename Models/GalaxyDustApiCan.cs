using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiCan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid? AccountId { get; set; }

    public int FleetSpace { get; set; }

    public virtual GalaxyDustApiAccount? Account { get; set; }

    public virtual ICollection<GalaxyDustApiAccountastrobot> GalaxyDustApiAccountastrobots { get; set; } = new List<GalaxyDustApiAccountastrobot>();

    public virtual ICollection<GalaxyDustApiAccountbadge> GalaxyDustApiAccountbadges { get; set; } = new List<GalaxyDustApiAccountbadge>();

    public virtual ICollection<GalaxyDustApiAccountbag> GalaxyDustApiAccountbags { get; set; } = new List<GalaxyDustApiAccountbag>();

    public virtual ICollection<GalaxyDustApiAccountblueprint> GalaxyDustApiAccountblueprints { get; set; } = new List<GalaxyDustApiAccountblueprint>();

    public virtual ICollection<GalaxyDustApiAccountcanactiveskill> GalaxyDustApiAccountcanactiveskills { get; set; } = new List<GalaxyDustApiAccountcanactiveskill>();

    public virtual ICollection<GalaxyDustApiAccountdefense> GalaxyDustApiAccountdefenses { get; set; } = new List<GalaxyDustApiAccountdefense>();

    public virtual ICollection<GalaxyDustApiAccountessence> GalaxyDustApiAccountessences { get; set; } = new List<GalaxyDustApiAccountessence>();

    public virtual ICollection<GalaxyDustApiAccountlicense> GalaxyDustApiAccountlicenses { get; set; } = new List<GalaxyDustApiAccountlicense>();

    public virtual ICollection<GalaxyDustApiAccountmaterializer> GalaxyDustApiAccountmaterializers { get; set; } = new List<GalaxyDustApiAccountmaterializer>();

    public virtual ICollection<GalaxyDustApiAccountpack> GalaxyDustApiAccountpacks { get; set; } = new List<GalaxyDustApiAccountpack>();

    public virtual ICollection<GalaxyDustApiAccountqmp> GalaxyDustApiAccountqmps { get; set; } = new List<GalaxyDustApiAccountqmp>();

    public virtual ICollection<GalaxyDustApiAccountrepairkit> GalaxyDustApiAccountrepairkits { get; set; } = new List<GalaxyDustApiAccountrepairkit>();

    public virtual ICollection<GalaxyDustApiAccountship> GalaxyDustApiAccountships { get; set; } = new List<GalaxyDustApiAccountship>();

    public virtual ICollection<GalaxyDustApiAccountstructure> GalaxyDustApiAccountstructures { get; set; } = new List<GalaxyDustApiAccountstructure>();

    public virtual ICollection<GalaxyDustApiAccounttechnology> GalaxyDustApiAccounttechnologies { get; set; } = new List<GalaxyDustApiAccounttechnology>();

    public virtual ICollection<GalaxyDustApiAccountticket> GalaxyDustApiAccounttickets { get; set; } = new List<GalaxyDustApiAccountticket>();

    public virtual ICollection<GalaxyDustApiAccounttool> GalaxyDustApiAccounttools { get; set; } = new List<GalaxyDustApiAccounttool>();

    public virtual ICollection<GalaxyDustApiCancurrencycapacity> GalaxyDustApiCancurrencycapacities { get; set; } = new List<GalaxyDustApiCancurrencycapacity>();

    public virtual ICollection<GalaxyDustApiCansafedeposit> GalaxyDustApiCansafedeposits { get; set; } = new List<GalaxyDustApiCansafedeposit>();
}
