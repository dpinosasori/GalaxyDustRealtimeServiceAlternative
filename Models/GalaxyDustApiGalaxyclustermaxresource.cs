using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiGalaxyclustermaxresource
{
    public int Id { get; set; }

    public double? MaxCurrency { get; set; }

    public int? CurrencyId { get; set; }

    public int GalaxyClusterId { get; set; }

    public virtual GalaxyDustApiCurrency? Currency { get; set; }

    public virtual GalaxyDustApiGalaxycluster GalaxyCluster { get; set; } = null!;
}
