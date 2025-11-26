using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiShipleveluprequirement
{
    public int Id { get; set; }

    public int LevelToEvolve { get; set; }

    public int ShipId { get; set; }

    public TimeSpan? LevelUpDuration { get; set; }

    public virtual ICollection<GalaxyDustApiCurrencyshipleveluprequirement> GalaxyDustApiCurrencyshipleveluprequirements { get; set; } = new List<GalaxyDustApiCurrencyshipleveluprequirement>();

    public virtual ICollection<GalaxyDustApiItemshipleveluprequirement> GalaxyDustApiItemshipleveluprequirements { get; set; } = new List<GalaxyDustApiItemshipleveluprequirement>();

    public virtual ICollection<GalaxyDustApiShipcategorylevelrequirement> GalaxyDustApiShipcategorylevelrequirements { get; set; } = new List<GalaxyDustApiShipcategorylevelrequirement>();

    public virtual GalaxyDustApiShipstat Ship { get; set; } = null!;
}
