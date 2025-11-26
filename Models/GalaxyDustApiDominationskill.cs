using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDominationskill
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? ActivationProbability { get; set; }

    public int? Stack { get; set; }

    public int? SkillTypeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GalaxyDustApiShipskilllevelgroup> GalaxyDustApiShipskilllevelgroups { get; set; } = new List<GalaxyDustApiShipskilllevelgroup>();

    public virtual GalaxyDustApiSkilltype? SkillType { get; set; }
}
