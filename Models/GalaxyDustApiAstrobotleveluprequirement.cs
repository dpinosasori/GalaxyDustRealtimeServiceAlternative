using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiAstrobotleveluprequirement
{
    public int Id { get; set; }

    public int LevelToEvolve { get; set; }

    public int AstrobotId { get; set; }

    public TimeSpan? LevelUpDuration { get; set; }

    public virtual GalaxyDustApiAstrobotstat Astrobot { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiAstrobotcategorylevelrequirement> GalaxyDustApiAstrobotcategorylevelrequirements { get; set; } = new List<GalaxyDustApiAstrobotcategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiCurrencyastrobotleveluprequirement> GalaxyDustApiCurrencyastrobotleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencyastrobotleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemastrobotleveluprequirement> GalaxyDustApiItemastrobotleveluprequirements { get; set; } = new List<GalaxyDustApiItemastrobotleveluprequirement>();
}
