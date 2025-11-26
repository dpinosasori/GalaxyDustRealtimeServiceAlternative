using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiDefenseleveluprequirement
{
    public int Id { get; set; }

    public int LevelToEvolve { get; set; }

    public int DefenseId { get; set; }

    public TimeSpan? LevelUpDuration { get; set; }

    public virtual GalaxyDustApiDefensestat Defense { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiCurrencydefenseleveluprequirement> GalaxyDustApiCurrencydefenseleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencydefenseleveluprequirement>();

    public virtual ICollection<GalaxyDustApiDefensecategorylevelrequirement> GalaxyDustApiDefensecategorylevelrequirements { get; set; } = new List<GalaxyDustApiDefensecategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiItemdefenseleveluprequirement> GalaxyDustApiItemdefenseleveluprequirements { get; set; } = new List<GalaxyDustApiItemdefenseleveluprequirement>();
}
