using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

public partial class R02
{
    public int Id { get; set; }

    public decimal CodigoInstFinanciera { get; set; }

    public string TipoIdentificacionSujeto { get; set; } = null!;

    public string IdentificacionSujeto { get; set; } = null!;

    public string NumeroOperacion { get; set; } = null!;

    public DateOnly FechaCorte { get; set; }

    public string TipoCredito { get; set; } = null!;

    public DateTime FechaConcesion { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public decimal ValorOperacion { get; set; }

    public DateTime FechaCancelacion { get; set; }
}
