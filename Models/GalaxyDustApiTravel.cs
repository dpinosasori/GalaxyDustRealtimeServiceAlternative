using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTravel
{
    public int Id { get; set; }

    public bool IsAutomatic { get; set; }

    public double? TimeToArriveInMinutes { get; set; }

    public double? TimeToReturnInMinutes { get; set; }

    public DateOnly? StartTravelDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid AccountId { get; set; }

    public Guid? StelarBodyId { get; set; }

    public string? Status { get; set; }

    public bool? StarDiscovered { get; set; }

    public bool? IsMining { get; set; }

    public virtual GalaxyDustApiAccount Account { get; set; } = null!;

    public virtual ICollection<GalaxyDustApiTraveldatum> GalaxyDustApiTraveldata { get; set; } = new List<GalaxyDustApiTraveldatum>();

    public virtual GalaxyDustApiStelarbody? StelarBody { get; set; }
}
