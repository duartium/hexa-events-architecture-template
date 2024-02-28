using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Correo { get; set; }

    public string Contrasena { get; set; } = null!;

    public int Rol { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaActualizacion { get; set; }
}
