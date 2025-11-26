using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiBadgeleveluprequirement
{
    public int Id { get; set; }

    public int LevelToEvolve { get; set; }

    public int BadgeId { get; set; }

    public TimeSpan? LevelUpDuration { get; set; }

    public virtual GalaxyDustApiBadgestat Badge { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiBadgecategorylevelrequirement> GalaxyDustApiBadgecategorylevelrequirements { get; set; } = new List<GalaxyDustApiBadgecategorylevelrequirement>();

    public virtual ICollection<GalaxyDustApiCurrencybadgeleveluprequirement> GalaxyDustApiCurrencybadgeleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencybadgeleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItembadgeleveluprequirement> GalaxyDustApiItembadgeleveluprequirements { get; set; } = new List<GalaxyDustApiItembadgeleveluprequirement>();
}
