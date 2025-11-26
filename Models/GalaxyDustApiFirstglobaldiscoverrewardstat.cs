using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiFirstglobaldiscoverrewardstat
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<GalaxyDustApiFirstglobaldiscoverrewardstar> GalaxyDustApiFirstglobaldiscoverrewardstars { get; set; } = new List<GalaxyDustApiFirstglobaldiscoverrewardstar>();

    public virtual ICollection<GalaxyDustApiFirstglobaldiscoverrewardstatcurrency> GalaxyDustApiFirstglobaldiscoverrewardstatcurrencies { get; set; } = new List<GalaxyDustApiFirstglobaldiscoverrewardstatcurrency>();

    public virtual ICollection<GalaxyDustApiFirstglobaldiscoverrewardstatitem> GalaxyDustApiFirstglobaldiscoverrewardstatitems { get; set; } = new List<GalaxyDustApiFirstglobaldiscoverrewardstatitem>();
}
