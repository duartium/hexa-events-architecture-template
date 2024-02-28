using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

/// <summary>
/// SUJETOS DE RIESGO
/// </summary>
public partial class R01
{
    public int Id { get; set; }

    public decimal CodigoInstFinanciera { get; set; }

    public string TipoIdentificacionSujeto { get; set; } = null!;

    public string IdentificacionSujeto { get; set; } = null!;

    public string NombreSujeto { get; set; } = null!;

    public string CausalVinculacion { get; set; } = null!;

    public string ClaseSujeto { get; set; } = null!;
}
