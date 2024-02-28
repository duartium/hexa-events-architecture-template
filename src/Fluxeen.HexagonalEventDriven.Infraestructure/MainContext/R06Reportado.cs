using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

/// <summary>
/// GARANTES Y CODEUDORES REPORTADOS EN EL MES
/// </summary>
public partial class R06Reportado
{
    public int Id { get; set; }

    public decimal CodigoInstFinanciera { get; set; }

    public string TipoIdentificacionSujeto { get; set; } = null!;

    public string IdentificacionSujeto { get; set; } = null!;

    public string NumeroOperacion { get; set; } = null!;

    public string TipoIdentificacionCodeudor { get; set; } = null!;

    public string IdentificacionCodeudor { get; set; } = null!;

    public DateTime FechaCorte { get; set; }

    public string TipoDeudor { get; set; } = null!;

    public DateTime FechaEliminacion { get; set; }
}
