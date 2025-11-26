using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiSkilltype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiBattleskill> GalaxyDustApiBattleskills { get; set; } = new List<GalaxyDustApiBattleskill>();

    public virtual ICollection<GalaxyDustApiDominationskill> GalaxyDustApiDominationskills { get; set; } = new List<GalaxyDustApiDominationskill>();

    public virtual ICollection<GalaxyDustApiExpeditionskill> GalaxyDustApiExpeditionskills { get; set; } = new List<GalaxyDustApiExpeditionskill>();

    public virtual ICollection<GalaxyDustApiExplorationskill> GalaxyDustApiExplorationskills { get; set; } = new List<GalaxyDustApiExplorationskill>();

    public virtual ICollection<GalaxyDustApiSkillstat> GalaxyDustApiSkillstats { get; set; } = new List<GalaxyDustApiSkillstat>();

    public virtual ICollection<GalaxyDustApiTransportskill> GalaxyDustApiTransportskills { get; set; } = new List<GalaxyDustApiTransportskill>();
}
