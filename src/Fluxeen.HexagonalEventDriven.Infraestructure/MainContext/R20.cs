using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

/// <summary>
/// APERTURAS DE TARJETAS DE CREDITO
/// </summary>
public partial class R20
{
    public int Id { get; set; }

    public decimal CodigoInstFinanciera { get; set; }

    public string TipoIdentificacion { get; set; } = null!;

    public string IdentificacionSujeto { get; set; } = null!;

    public decimal TipoTarjeta { get; set; }

    public string NumeroTarjeta { get; set; } = null!;

    public string ClaseTarjeta { get; set; } = null!;

    public DateTime FechaCorte { get; set; }

    public DateTime FechaConcesion { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public decimal ValorCupo { get; set; }
}
