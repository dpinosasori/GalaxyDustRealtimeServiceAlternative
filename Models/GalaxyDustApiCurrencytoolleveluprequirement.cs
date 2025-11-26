using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiCurrencytoolleveluprequirement
{
    public long Id { get; set; }

    public double Amount { get; set; }

    public bool? IsBurnable { get; set; }

    public int CurrencyId { get; set; }

    public int RequirementId { get; set; }

    public virtual GalaxyDustApiCurrency Currency { get; set; } = null!;

    public virtual GalaxyDustApiToolleveluprequirement Requirement { get; set; } = null!;
}
