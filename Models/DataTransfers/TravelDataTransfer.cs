namespace GalaxyDustRealtimeService.Models.DataTransfers;

public class TravelUpdateDto
{
    public int TravelId { get; set; }
    public string Status { get; set; } // FLYING, BATTLE, MINING, RETURNING
    public double ProgressPercent { get; set; }
    public double RemainingMinutes { get; set; }
    public double TotalMinutes { get; set; }
    public string CurrentMessage { get; set; } // Mensaje del evento actual o estado
    public TravelContextDto Context { get; set; } // Datos completos (Naves, Estrellas, etc.)
}

// Contexto completo del vuelo
public class TravelContextDto
{
    public StarInfoDto DestinationStar { get; set; }
    public FleetCompositionDto Fleet { get; set; }
}

public class StarInfoDto
{
    public string Name { get; set; }
    public string Coords { get; set; }
    public string Type { get; set; }
    public double DangerLevel { get; set; }
    public int PlanetCount { get; set; }
    public double ResourceRichness { get; set; } // Ejemplo derivado de StarStat
}

public class FleetCompositionDto
{
    public List<ShipDetailDto> Ships { get; set; } = new();
    public List<AstrobotDetailDto> Astrobots { get; set; } = new();
    public List<ToolDetailDto> Tools { get; set; } = new();
    public double TotalFleetHealth { get; set; }
    public double CurrentFleetHealth { get; set; }
}

public class ShipDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; } // Nombre del ShipType o Fuselage
    public double Health { get; set; }
    public double MaxHealth { get; set; }
    public double Shield { get; set; }
    public double AttackPower { get; set; }
}

public class AstrobotDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public double Bonus { get; set; }
}

public class ToolDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Durability { get; set; }
}