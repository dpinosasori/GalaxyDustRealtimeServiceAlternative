using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiShipstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public double Production { get; set; }

    public double Cargo { get; set; }

    public double TotalHealth { get; set; }

    public double Shield { get; set; }

    public double Speed { get; set; }

    public double Defense { get; set; }

    public double KineticAttack { get; set; }

    public double IonAttack { get; set; }

    public double LaserAttack { get; set; }

    public double PlasmaAttack { get; set; }

    public double GravitonAttack { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double PowerScore { get; set; }

    public double CombatSpeed { get; set; }

    public double FleetSpace { get; set; }

    public int? CollectionId { get; set; }

    public int? CompanyId { get; set; }

    public int? EngineId { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public int? SerieId { get; set; }

    public int? ShipSizeId { get; set; }

    public int MaxLevel { get; set; }

    public string? FileDirection { get; set; }

    public virtual GalaxyDustApiCollection? Collection { get; set; }

    public virtual GalaxyDustApiCompany? Company { get; set; }

    public virtual GalaxyDustApiEngine? Engine { get; set; }

    public virtual ICollection<GalaxyDustApiAccountship> GalaxyDustApiAccountships { get; set; } = new List<GalaxyDustApiAccountship>();

    public virtual ICollection<GalaxyDustApiDestroyed> GalaxyDustApiDestroyeds { get; set; } = new List<GalaxyDustApiDestroyed>();

    public virtual ICollection<GalaxyDustApiEnemyship> GalaxyDustApiEnemyships { get; set; } = new List<GalaxyDustApiEnemyship>();

    public virtual ICollection<GalaxyDustApiShipfuselagegroup> GalaxyDustApiShipfuselagegroups { get; set; } = new List<GalaxyDustApiShipfuselagegroup>();

    public virtual ICollection<GalaxyDustApiShipleveluprequirement> GalaxyDustApiShipleveluprequirements { get; set; } = new List<GalaxyDustApiShipleveluprequirement>();

    public virtual ICollection<GalaxyDustApiShipskilllevelgroup> GalaxyDustApiShipskilllevelgroups { get; set; } = new List<GalaxyDustApiShipskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiShiptypegroup> GalaxyDustApiShiptypegroups { get; set; } = new List<GalaxyDustApiShiptypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }

    public virtual GalaxyDustApiSerie? Serie { get; set; }

    public virtual GalaxyDustApiShipsize? ShipSize { get; set; }
}
