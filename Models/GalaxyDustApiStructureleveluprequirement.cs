using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiStructureleveluprequirement
{
    public int Id { get; set; }

    public int LevelToEvolve { get; set; }

    public int StructureId { get; set; }

    public TimeSpan? LevelUpDuration { get; set; }

    public virtual ICollection<GalaxyDustApiCurrencystructureleveluprequirement> GalaxyDustApiCurrencystructureleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencystructureleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemstructureleveluprequirement> GalaxyDustApiItemstructureleveluprequirements { get; set; } = new List<GalaxyDustApiItemstructureleveluprequirement>();

    public virtual ICollection<GalaxyDustApiStructurecategorylevelrequirement> GalaxyDustApiStructurecategorylevelrequirements { get; set; } = new List<GalaxyDustApiStructurecategorylevelrequirement>();

    public virtual GalaxyDustApiStructurestat Structure { get; set; } = null!;
}
