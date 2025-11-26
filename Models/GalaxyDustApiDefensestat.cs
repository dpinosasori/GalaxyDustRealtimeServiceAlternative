using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDefensestat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public double TotalHealth { get; set; }

    public double Shield { get; set; }

    public double Defense { get; set; }

    public double KineticAttack { get; set; }

    public double IonAttack { get; set; }

    public double LaserAttack { get; set; }

    public double PlasmaAttack { get; set; }

    public double GravitonAttack { get; set; }

    public double PowerScore { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? DefenseSizeId { get; set; }

    public Guid? ItemId { get; set; }

    public int? RarityId { get; set; }

    public int MaxLevel { get; set; }

    public string? FileDirection { get; set; }

    public virtual GalaxyDustApiDefensesize? DefenseSize { get; set; }

    public virtual ICollection<GalaxyDustApiAccountdefense> GalaxyDustApiAccountdefenses { get; set; } = new List<GalaxyDustApiAccountdefense>();

    public virtual ICollection<GalaxyDustApiDefenseleveluprequirement> GalaxyDustApiDefenseleveluprequirements { get; set; } = new List<GalaxyDustApiDefenseleveluprequirement>();

    public virtual ICollection<GalaxyDustApiDefenseskilllevelgroup> GalaxyDustApiDefenseskilllevelgroups { get; set; } = new List<GalaxyDustApiDefenseskilllevelgroup>();

    public virtual ICollection<GalaxyDustApiDefensetypegroup> GalaxyDustApiDefensetypegroups { get; set; } = new List<GalaxyDustApiDefensetypegroup>();

    public virtual GalaxyDustApiItem? Item { get; set; }

    public virtual GalaxyDustApiRaritytype? Rarity { get; set; }
}
