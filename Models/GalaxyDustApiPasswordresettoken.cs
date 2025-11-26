using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiPasswordresettoken
{
    public int Id { get; set; }

    public string Token { get; set; } = null!;

    public DateTime Created { get; set; }

    public bool IsUsed { get; set; }

    public Guid AccountId { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;
}
