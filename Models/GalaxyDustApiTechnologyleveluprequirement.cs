using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTechnologyleveluprequirement
{
    public int Id { get; set; }

    public int LevelToEvolve { get; set; }

    public int TechnologyId { get; set; }

    public TimeSpan? LevelUpDuration { get; set; }

    public virtual ICollection<GalaxyDustApiCurrencytechnologyleveluprequirement> GalaxyDustApiCurrencytechnologyleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencytechnologyleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemtechnologyleveluprequirement> GalaxyDustApiItemtechnologyleveluprequirements { get; set; } = new List<GalaxyDustApiItemtechnologyleveluprequirement>();

    public virtual ICollection<GalaxyDustApiTechnologycategorylevelrequirement> GalaxyDustApiTechnologycategorylevelrequirements { get; set; } = new List<GalaxyDustApiTechnologycategorylevelrequirement>();

    public virtual GalaxyDustApiTechnologystat Technology { get; set; } = null!;
}
