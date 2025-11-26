using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiSkillstat
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Stack { get; set; }

    public double? ActivationProbability { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double? CombatSpeedPoints { get; set; }

    public double? CombatSpeedPercentage { get; set; }

    public double? CrystalProduction { get; set; }

    public double? CrystalProductionPercentage { get; set; }

    public double? DarkMatterProduction { get; set; }

    public double? DarkMatterProductionPercentage { get; set; }

    public double? DeuteriumProduction { get; set; }

    public double? DeuteriumProductionPercentage { get; set; }

    public double? DuplicateTechnologyAndBuildingsOnCreationPercentage { get; set; }

    public double? FleetCargoPercentage { get; set; }

    public double? FleetCargoPoints { get; set; }

    public double? FleetCombatSpeedPercentage { get; set; }

    public double? FleetCombatSpeedPoints { get; set; }

    public double? FleetGravitonAttackPercentage { get; set; }

    public double? FleetGravitonAttackPoints { get; set; }

    public double? FleetGravitonDefensePercentage { get; set; }

    public double? FleetGravitonDefensePoints { get; set; }

    public double? FleetIonicAttackPercentage { get; set; }

    public double? FleetIonicAttackPoints { get; set; }

    public double? FleetIonicDefensePercentage { get; set; }

    public double? FleetIonicDefensePoints { get; set; }

    public double? FleetKineticAttackPercentage { get; set; }

    public double? FleetKineticAttackPoints { get; set; }

    public double? FleetKineticDefensePercentage { get; set; }

    public double? FleetKineticDefensePoints { get; set; }

    public double? FleetLaserAttackPercentage { get; set; }

    public double? FleetLaserAttackPoints { get; set; }

    public double? FleetLaserDefensePercentage { get; set; }

    public double? FleetLaserDefensePoints { get; set; }

    public double? FleetPlasmaAttackPercentage { get; set; }

    public double? FleetPlasmaAttackPoints { get; set; }

    public double? FleetPlasmaDefensePercentage { get; set; }

    public double? FleetPlasmaDefensePoints { get; set; }

    public double? FleetShieldPercentage { get; set; }

    public double? FleetShieldPoints { get; set; }

    public double? FleetSpeedPercentage { get; set; }

    public double? FleetSpeedPoints { get; set; }

    public double? GravitonAttackPercentage { get; set; }

    public double? GravitonAttackPoints { get; set; }

    public double? GravitonDefensePercentage { get; set; }

    public double? GravitonDefensePoints { get; set; }

    public double? IonicAttackPercentage { get; set; }

    public double? IonicAttackPoints { get; set; }

    public double? IonicDefensePercentage { get; set; }

    public double? IonicDefensePoints { get; set; }

    public double? KineticAttackPercentage { get; set; }

    public double? KineticAttackPoints { get; set; }

    public double? KineticDefensePercentage { get; set; }

    public double? KineticDefensePoints { get; set; }

    public double? LaserAttackPercentage { get; set; }

    public double? LaserAttackPoints { get; set; }

    public double? LaserDefensePercentage { get; set; }

    public double? MetalProduction { get; set; }

    public double? MetalProductionPercentage { get; set; }

    public double? LaserDefensePoints { get; set; }

    public double? MirrorDamagePercentage { get; set; }

    public double? MirrorDamagePoints { get; set; }

    public double? PlasmaAttackPercentage { get; set; }

    public double? PlasmaAttackPoints { get; set; }

    public double? PlasmaDefensePercentage { get; set; }

    public double? PlasmaDefensePoints { get; set; }

    public double? PreventDamagePercentage { get; set; }

    public double? ResourceProduction { get; set; }

    public double? ResourceProductionPercentage { get; set; }

    public int? SkillTypeId { get; set; }

    public double? PreventDamagePoints { get; set; }

    public double? TotalDamagePercentage { get; set; }

    public double? TotalDamagePoints { get; set; }

    public double? TotalDefensePercentage { get; set; }

    public double? TotalDefensePoints { get; set; }

    public double? TransportSpeedPercentage { get; set; }

    public double? PhantomCoinProduction { get; set; }

    public double? PhantomCoinProductionPercentage { get; set; }

    public double? AlienCrafterPercentage { get; set; }

    public double? EnergyProduction { get; set; }

    public double? EnergyProductionPercentage { get; set; }

    public double? InstantTechnologyCreationPercentage { get; set; }

    public double? InstantTravelPercentage { get; set; }

    public double? NotConsumeBlueprintUsePercentage { get; set; }

    public double? NotConsumeResourcesBuildingStructuresPercentage { get; set; }

    public double? NotConsumeResourcesCreatingTechnologiesPercentage { get; set; }

    public double? RandomTechnologyCreationUsingBlueprintPercentage { get; set; }

    public double? ReduceBuildingUpgradingCostPercentage { get; set; }

    public double? ReduceBuildingUpgradingTimePercentage { get; set; }

    public double? ReduceCreationCostPercentage { get; set; }

    public double? ReduceCreationTime { get; set; }

    public double? ReduceCreationTimePercentage { get; set; }

    public double? ReduceEnergyConsumptionPercentage { get; set; }

    public double? ReduceTechCreationCost { get; set; }

    public double? ReduceTechCreationCostPercentage { get; set; }

    public double? ReduceTechCreationTime { get; set; }

    public double? ReduceTechCreationTimePercentage { get; set; }

    public double? TransportSpeedPoints { get; set; }

    public double? AstrobotsMaterialProductionPercentage { get; set; }

    public double? FreeRepairPercentage { get; set; }

    public double? ReduceAstrobotsRepairCostsPercentage { get; set; }

    public double? ReduceRepairCostsPercentage { get; set; }

    public double? ReduceShipCreationTimePercentage { get; set; }

    public double? ChanceOfExtractingPureGdPercentage { get; set; }

    public double? DeuteriumProductionPer100kResourcesProduced { get; set; }

    public double? DuplicatePureGdPercentage { get; set; }

    public double? DuplicateShipOnCreationFromEpicOrRarerBpPercentage { get; set; }

    public double? DuplicateShipOnCreationPercentage { get; set; }

    public double? FleetSpacePercentage { get; set; }

    public double? FleetSpacePoints { get; set; }

    public double? FleetTotalDamagePercentage { get; set; }

    public double? FleetTotalDamagePoints { get; set; }

    public double? FleetTotalDefensePercentage { get; set; }

    public double? FleetTotalDefensePoints { get; set; }

    public double? HigherRarityPureGdProductionPercentage { get; set; }

    public double? IncreasesBadgeSlots { get; set; }

    public double? IncreasesCrystalSafeDeposit { get; set; }

    public double? IncreasesDarkMatterSafeDeposit { get; set; }

    public double? IncreasesDeuteriumSafeDeposit { get; set; }

    public double? IncreasesMaterialProductionOnExpeditionsPercentage { get; set; }

    public double? IncreasesMetalSafeDeposit { get; set; }

    public double? IncreasesMinesMaterialProductionPercentage { get; set; }

    public double? IncreasesPureGdMinerPercentage { get; set; }

    public double? IncreasesSafeExtractionPercentage { get; set; }

    public double? IncreasesTechnologyCreationTimePercentage { get; set; }

    public double? InstantBuildingCreationPercentage { get; set; }

    public double? InstantShipCreationPercentage { get; set; }

    public double? InstantStructureUpgradePercentage { get; set; }

    public double? InstantTechnologyUpgradePercentage { get; set; }

    public bool? NeoTransmuter { get; set; }

    public bool? Recycler { get; set; }

    public double? ReduceAstrobotsCreationCostsPercentage { get; set; }

    public double? ReduceBurningCostPercentage { get; set; }

    public double? ReduceExpeditionTravelTimePercentage { get; set; }

    public double? ReduceExpeditionTravelTimeSeconds { get; set; }

    public double? ReduceExplorationDamageProbabilityPercentage { get; set; }

    public double? ReduceResourcesCostToLevelUpStructuresPercentage { get; set; }

    public double? ReduceResourcesCostToLevelUpTechnologiesPercentage { get; set; }

    public double? ReduceShipCreationCostPercentage { get; set; }

    public double? ReduceTimeToLevelUpStructuresPercentage { get; set; }

    public double? ReduceTimeToLevelUpTechnologiesPercentage { get; set; }

    public bool? SasoriExplorationSpyTech { get; set; }

    public bool? Terraformer { get; set; }

    public bool? Xmas23Recycler { get; set; }

    public double? ChanceOfConsumeHalfDominationSlotsPercentage { get; set; }

    public double? DominationFleetSpacePercentage { get; set; }

    public double? DominationFleetSpacePoints { get; set; }

    public double? DominationInstantTravelPercentage { get; set; }

    public bool? DominationResuplyOne { get; set; }

    public double? ExplorationFleetSpacePercentage { get; set; }

    public double? ExplorationFleetSpacePoints { get; set; }

    public double? IncreasesAttackToAllDefensesPercentage { get; set; }

    public double? IncreasesAttackToAllShipsPercentage { get; set; }

    public double? IncreasesDefenseToAllDefensesPercentage { get; set; }

    public double? IncreasesDefenseToAllShipsPercentage { get; set; }

    public double? IncreasesMetalFuselageOnDominationExpeditionsPercentage { get; set; }

    public double? IncreasesMinersShipCargoPercentage { get; set; }

    public double? IncreasesShieldToAllShipsPercentage { get; set; }

    public double? IncreasesTotalDamageForMetallicFuselageShipsPercentage { get; set; }

    public double? IncreasesTotalDamageForSpectralFuselageShipsPercentage { get; set; }

    public double? IncreasesTotalDefenseForMetallicFuselageShipsPercentage { get; set; }

    public double? IncreasesTotalDefenseForSpectralFuselageShipsPercentage { get; set; }

    public double? ReduceExpeditionTravelCostPercentage { get; set; }

    public double? ReduceFleetTravelingCostsPercentage { get; set; }

    public double? ReduceLostSectorExpeditionDeuteriumAndGdCostPercentage { get; set; }

    public double? ReduceTransportCostPercentage { get; set; }

    public double? ReduceTransportTimePercentage { get; set; }

    public double? TransportationCapacityPercentage { get; set; }

    public double? TransportationCapacityPoints { get; set; }

    public double? TransportationFleetSpacePercentage { get; set; }

    public double? TransportationFleetSpacePoints { get; set; }

    public double? TransportationShipsDefensePercentage { get; set; }

    public double? TransportationShipsDefensePoints { get; set; }

    public double? TransportationSpaceShipCargoPercentage { get; set; }

    public double? IncreasesDarkMatterProductionOnDominationExpMultiplier { get; set; }

    public double? IncreasesDeuteriumProductionOnDominationExpMultiplier { get; set; }

    public double? IncreasesSpectralFuselageOnDominationExpPercentage { get; set; }

    public double? InstantShipUpgradePercentage { get; set; }

    public double? IncreasesBaseCrystalCapacity { get; set; }

    public double? IncreasesBaseDarkMatterCapacity { get; set; }

    public double? IncreasesBaseDefenePercentage { get; set; }

    public double? IncreasesBaseDeuteriumCapacity { get; set; }

    public double? IncreasesBaseMetalCapacity { get; set; }

    public double? IncreasesBaseShieldCreatingSomethingPercentage { get; set; }

    public double? IncreasesBaseShieldPercentage { get; set; }

    public double? IncreasesBaseShieldPoints { get; set; }

    public double? IncreasesColonizableBasessPoint { get; set; }

    public double? IncreasesShieldToAllBasesPercentage { get; set; }

    public double? IncreasesCrystalSafeDepositPercentage { get; set; }

    public double? IncreasesDarkMatterSafeDepositPercentage { get; set; }

    public double? IncreasesDeuteriumSafeDepositPercentage { get; set; }

    public double? IncreasesMetalSafeDepositPercentage { get; set; }

    public bool? SasoriInsuranceOne { get; set; }

    public double? IncreasesFleetTravelWhenMinerShipsFullFleetPercentage { get; set; }

    public bool? AstrobotSlots { get; set; }

    public double? ChanceOfRepairFleetUponExpeditionPercentage { get; set; }

    public double? CrystalProductionBoostPercentage { get; set; }

    public double? DeuteriumProductionBoostPercentage { get; set; }

    public double? DeuteriumProductionPerExpeditionPercentage { get; set; }

    public double? GalaxyBladeObliterationPercentage { get; set; }

    public double? IncreasesExpeditionRewardPercentage { get; set; }

    public double? MetalProductionBoostPercentage { get; set; }

    public double? NovaDefensePercentage { get; set; }

    public bool? NoDamagePvp { get; set; }

    public virtual ICollection<GalaxyDustApiAccountcanactiveskill> GalaxyDustApiAccountcanactiveskills { get; set; } = new List<GalaxyDustApiAccountcanactiveskill>();

    public virtual ICollection<GalaxyDustApiAstrobotskilllevelgroup> GalaxyDustApiAstrobotskilllevelgroups { get; set; } = new List<GalaxyDustApiAstrobotskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiBadgeskilllevelgroup> GalaxyDustApiBadgeskilllevelgroups { get; set; } = new List<GalaxyDustApiBadgeskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiDefenseskilllevelgroup> GalaxyDustApiDefenseskilllevelgroups { get; set; } = new List<GalaxyDustApiDefenseskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiFleetaccountactiveskill> GalaxyDustApiFleetaccountactiveskills { get; set; } = new List<GalaxyDustApiFleetaccountactiveskill>();

    public virtual ICollection<GalaxyDustApiSkillrequirement> GalaxyDustApiSkillrequirements { get; set; } = new List<GalaxyDustApiSkillrequirement>();

    public virtual ICollection<GalaxyDustApiStructureskilllevelgroup> GalaxyDustApiStructureskilllevelgroups { get; set; } = new List<GalaxyDustApiStructureskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiTechnologyskilllevelgroup> GalaxyDustApiTechnologyskilllevelgroups { get; set; } = new List<GalaxyDustApiTechnologyskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiToolskilllevelgroup> GalaxyDustApiToolskilllevelgroups { get; set; } = new List<GalaxyDustApiToolskilllevelgroup>();

    public virtual GalaxyDustApiSkilltype? SkillType { get; set; }
}
