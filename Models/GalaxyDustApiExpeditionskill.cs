using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiExpeditionskill
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? ActivationProbability { get; set; }

    public int? Stack { get; set; }

    public int? SkillTypeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public double? FleefLaserAttackPercentage { get; set; }

    public double? FleetAttackPercentage { get; set; }

    public double? FleetCargoPoints { get; set; }

    public double? FleetIonicAttackPercentage { get; set; }

    public double? FleetShieldPercentage { get; set; }

    public double? FleetSpeedPercentage { get; set; }

    public double? GoraRevengePercentage { get; set; }

    public double? GravitonDefensePercentage { get; set; }

    public double? NovaDefensePercentage { get; set; }

    public double? OriginalNovaPercentage { get; set; }

    public double? ShieldDamagePercentage { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool? AstrobotSlots { get; set; }

    public bool? BetterCleanse { get; set; }

    public double? ChanceToDoubleExpeditionRewardsPercentage { get; set; }

    public double? ChanceToRepairFleetPercentage { get; set; }

    public double? ExpeditionCostPercentage { get; set; }

    public double? ExpeditionRewardsPercentage { get; set; }

    public double? FleetAllAttacksPercentage { get; set; }

    public double? FleetCapacityPercentage { get; set; }

    public double? FleetCapacityPoints { get; set; }

    public double? FleetCargoPercentage { get; set; }

    public double? FleetDefensePercentage { get; set; }

    public double? FleetGravitonAttackPercentage { get; set; }

    public double? FleetPlasmaAttackPercentage { get; set; }

    public bool? GalaxyBladeObliteration { get; set; }

    public double? InstantTravelPercentage { get; set; }

    public bool? KalvacAttacker { get; set; }

    public bool? KalvacExplorer { get; set; }

    public bool? KalvacHealer { get; set; }

    public bool? KalvacTransporter { get; set; }

    public double? LaserDefensePercentage { get; set; }

    public bool? LuxCleaningGd { get; set; }

    public bool? LuxProductionGd { get; set; }

    public bool? LuxTicketsGd { get; set; }

    public bool? LuxTravelGd { get; set; }

    public bool? MagnusBlessing { get; set; }

    public double? MaxFleetDefensePercentage { get; set; }

    public double? MaxFleetSpeedPercentage { get; set; }

    public double? ProductionBoostCrystalPercentage { get; set; }

    public double? ProductionBoostDeuteriumPercentage { get; set; }

    public double? ProductionBoostMetalPercentage { get; set; }

    public double? ProductionPerExpeditionDeuteriumPercentage { get; set; }

    public double? ReduceFleetSpeedHiperspaceShipsPercentage { get; set; }

    public double? ReflectAttackPercentage { get; set; }

    public double? ReflectDebuffPercentage { get; set; }

    public double? RepairFleetPercentage { get; set; }

    public bool? TravelToAnySector { get; set; }

    public double? AlwaysProducesCrystalPoints { get; set; }

    public double? AlwaysProducesMetalPoints { get; set; }

    public double? InvinciblePercentage { get; set; }

    public bool? MagnusArmour { get; set; }

    public bool? MagnusLightSpeed { get; set; }

    public bool? StingSwarmg { get; set; }

    public bool? ZeusRampage { get; set; }

    public bool? ZeusSpark { get; set; }

    public double? FleetShieldPoints { get; set; }

    public virtual ICollection<GalaxyDustApiShipskilllevelgroup> GalaxyDustApiShipskilllevelgroups { get; set; } = new List<GalaxyDustApiShipskilllevelgroup>();

    public virtual GalaxyDustApiSkilltype? SkillType { get; set; }
}
