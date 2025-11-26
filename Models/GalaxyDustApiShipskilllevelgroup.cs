using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiShipskilllevelgroup
{
    public int Id { get; set; }

    public int Level { get; set; }

    public int BlockGroup { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? ShipId { get; set; }

    public int? BattleSkillId { get; set; }

    public int? DominationSkillId { get; set; }

    public int? ExpeditionSkillId { get; set; }

    public int? ExplorationSkillId { get; set; }

    public int? TransportSkillId { get; set; }

    public virtual GalaxyDustApiBattleskill? BattleSkill { get; set; }

    public virtual GalaxyDustApiDominationskill? DominationSkill { get; set; }

    public virtual GalaxyDustApiExpeditionskill? ExpeditionSkill { get; set; }

    public virtual GalaxyDustApiExplorationskill? ExplorationSkill { get; set; }

    public virtual GalaxyDustApiShipstat? Ship { get; set; }

    public virtual GalaxyDustApiTransportskill? TransportSkill { get; set; }
}
