using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiToolleveluprequirement
{
    public int Id { get; set; }

    public int LevelToEvolve { get; set; }

    public int ToolId { get; set; }

    public TimeSpan? LevelUpDuration { get; set; }

    public virtual ICollection<GalaxyDustApiCurrencytoolleveluprequirement> GalaxyDustApiCurrencytoolleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencytoolleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemtoolleveluprequirement> GalaxyDustApiItemtoolleveluprequirements { get; set; } = new List<GalaxyDustApiItemtoolleveluprequirement>();

    public virtual ICollection<GalaxyDustApiToolcategorylevelrequirement> GalaxyDustApiToolcategorylevelrequirements { get; set; } = new List<GalaxyDustApiToolcategorylevelrequirement>();

    public virtual GalaxyDustApiToolstat Tool { get; set; } = null!;
}
