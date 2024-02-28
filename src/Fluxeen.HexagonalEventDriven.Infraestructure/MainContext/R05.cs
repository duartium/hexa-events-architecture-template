using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

public partial class R05
{
    public int Id { get; set; }

    public decimal CodigoInstFinanciera { get; set; }

    public string TipoIdentificacion { get; set; } = null!;

    public string Identificacion { get; set; } = null!;

    public string NumeroOperacion { get; set; } = null!;

    public decimal TipoTarjeta { get; set; }

    public string FormaCancelacion { get; set; } = null!;

    public DateTime FechaCancelacion { get; set; }

    public string Calificacion { get; set; } = null!;
}
