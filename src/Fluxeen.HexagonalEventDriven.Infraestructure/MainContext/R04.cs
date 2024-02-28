using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

/// <summary>
/// SALDOS
/// </summary>
public partial class R04
{
    public int Id { get; set; }

    public decimal CodigoInstFinanciera { get; set; }

    public string TipoIdentificacion { get; set; } = null!;

    public string Identificacion { get; set; } = null!;

    public string NumeroOperacion { get; set; } = null!;

    public DateTime FechaCorte { get; set; }

    public decimal SaldoVencer130Dias { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 1 a 3 meses
    /// </summary>
    public decimal SaldoVencer13Meses { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 3 a 6 meses
    /// </summary>
    public decimal SaldoVencer36Meses { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 6 a 12 meses
    /// </summary>
    public decimal SaldoVencer612Meses { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 12 meses
    /// </summary>
    public decimal SaldoVencer12masMeses { get; set; }

    public decimal ValorComisionVencer { get; set; }

    public decimal ValorNoDevengaInteres130Dias { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 1 a 3 meses 
    /// </summary>
    public decimal ValorNoDevengaInteres13Meses { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 3 a 6 meses 
    /// </summary>
    public decimal ValorNoDevengaInteres36Meses { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 6 a 12 meses 
    /// </summary>
    public decimal ValorNoDevengaInteres612Meses { get; set; }

    /// <summary>
    /// Valor que no devenga Interés más de 12 meses 
    /// </summary>
    public decimal ValorNoDevengaInteres12masMeses { get; set; }

    public decimal ValorVencido130Dias { get; set; }

    /// <summary>
    /// Valor vencido más de 1 a 2 meses
    /// </summary>
    public decimal ValorVencido12Meses { get; set; }

    /// <summary>
    /// Valor vencido más de 2 a 3 meses
    /// </summary>
    public decimal ValorVencido23Meses { get; set; }

    /// <summary>
    /// Valor vencido más de 3 a 6 meses
    /// </summary>
    public decimal ValorVencido36Meses { get; set; }

    /// <summary>
    /// Valor vencido más de 6 a 9 meses
    /// </summary>
    public decimal ValorVencido69Meses { get; set; }

    /// <summary>
    /// Valor vencido más de 9 a 12 meses
    /// </summary>
    public decimal ValorVencido912Meses { get; set; }

    /// <summary>
    /// Valor vencido más de 12 a 24 meses
    /// </summary>
    public decimal ValorVencido1224Meses { get; set; }

    /// <summary>
    /// Valor vencido más de 24 a 36 meses
    /// </summary>
    public decimal ValorVencido2436Meses { get; set; }

    /// <summary>
    /// Valor vencido más de 36 meses
    /// </summary>
    public decimal ValorVencido36masMeses { get; set; }

    public decimal ValorDemandaJudicial { get; set; }

    public decimal CarteraCastigada { get; set; }

    public string TipoOperacion { get; set; } = null!;

    public string EstadoOperacion { get; set; } = null!;
}
