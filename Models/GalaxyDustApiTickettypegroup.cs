using System;
using System.Collections.Generic;

namespace GalaxyDustRealtimeService.Models;

public partial class GalaxyDustApiTickettypegroup
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? TicketId { get; set; }

    public int? TicketTypeId { get; set; }

    public virtual GalaxyDustApiTicketstat? Ticket { get; set; }

    public virtual GalaxyDustApiTickettype? TicketType { get; set; }
}
