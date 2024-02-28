using System;
using System.Collections.Generic;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

/// <summary>
/// CONSUMOS DE TARJETAS
/// </summary>
public partial class R21
{
    public int Id { get; set; }

    public decimal CodigoInstFinanciera { get; set; }

    public string TipoIdentificacionSujeto { get; set; } = null!;

    public string IdentificacionSujeto { get; set; } = null!;

    public decimal TipoTarjeta { get; set; }

    public decimal NumeroTarjeta { get; set; }

    public string TipoCreditoOperacion { get; set; } = null!;

    public string TipoCreditoTarjeta { get; set; } = null!;

    public DateTime FechaCorte { get; set; }

    public decimal CapitalConsumo { get; set; }

    public decimal CapitalVencer130Dias { get; set; }

    public decimal CapitalVencer13Meses { get; set; }

    public decimal CapitalVencer36Meses { get; set; }

    public decimal CapitalVencer612Meses { get; set; }

    public decimal CapitalVencer12masMeses { get; set; }

    public decimal CostosOperativosVencer { get; set; }

    public decimal ValorNoDevengaInteres130Dias { get; set; }

    public decimal ValorNoDevengaInteres13Meses { get; set; }

    public decimal ValorNoDevengaInteres36Meses { get; set; }

    public decimal ValorNoDevengaInteres612Meses { get; set; }

    public decimal ValorNoDevengaInteres12masMeses { get; set; }

    public decimal CapitalVencido115Dias { get; set; }

    public decimal CapitalVencido1545Dias { get; set; }

    public decimal CapitalVencido4590Dias { get; set; }

    public decimal CapitalVencido90120Dias { get; set; }

    public decimal CapitalVencido120dias9meses { get; set; }

    public decimal CapitalVencido9masMeses { get; set; }

    public decimal TotalCostosOperativosVencidos { get; set; }

    public decimal ValorDemandaJudicial { get; set; }

    public decimal CateraCastigada { get; set; }
}
