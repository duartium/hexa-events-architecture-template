using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;

public partial class BGEstructurasDbContext : DbContext
{
    public BGEstructurasDbContext()
    {
    }

    public BGEstructurasDbContext(DbContextOptions<BGEstructurasDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<R01> R01s { get; set; }

    public virtual DbSet<R02> R02s { get; set; }

    public virtual DbSet<R04> R04s { get; set; }

    public virtual DbSet<R05> R05s { get; set; }

    public virtual DbSet<R06Cancelado> R06Cancelados { get; set; }

    public virtual DbSet<R06Reportado> R06Reportados { get; set; }

    public virtual DbSet<R20> R20s { get; set; }

    public virtual DbSet<R21> R21s { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=estructuras_administrador_BG;User Id=sa;Password=passuu@rd123*;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<R01>(entity =>
        {
            entity.ToTable("R01", tb => tb.HasComment("SUJETOS DE RIESGO"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CausalVinculacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("causal_vinculacion");
            entity.Property(e => e.ClaseSujeto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("clase_sujeto");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.IdentificacionSujeto)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_sujeto");
            entity.Property(e => e.NombreSujeto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre_sujeto");
            entity.Property(e => e.TipoIdentificacionSujeto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion_sujeto");
        });

        modelBuilder.Entity<R02>(entity =>
        {
            entity.ToTable("R02");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FechaConcesion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_concesion");
            entity.Property(e => e.FechaCorte).HasColumnName("fecha_corte");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdentificacionSujeto)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_sujeto");
            entity.Property(e => e.NumeroOperacion)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numero_operacion");
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_credito");
            entity.Property(e => e.TipoIdentificacionSujeto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion_sujeto");
            entity.Property(e => e.ValorOperacion)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_operacion");
        });

        modelBuilder.Entity<R04>(entity =>
        {
            entity.ToTable("R04", tb => tb.HasComment("SALDOS"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarteraCastigada)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("cartera_castigada");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.EstadoOperacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado_operacion");
            entity.Property(e => e.FechaCorte)
                .HasColumnType("datetime")
                .HasColumnName("fecha_corte");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion");
            entity.Property(e => e.NumeroOperacion)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numero_operacion");
            entity.Property(e => e.SaldoVencer12masMeses)
                .HasComment("Valor que no devenga Interés más de 12 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("saldo_vencer_12mas_meses");
            entity.Property(e => e.SaldoVencer130Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("saldo_vencer_1_30_dias");
            entity.Property(e => e.SaldoVencer13Meses)
                .HasComment("Valor que no devenga Interés más de 1 a 3 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("saldo_vencer_1_3_meses");
            entity.Property(e => e.SaldoVencer36Meses)
                .HasComment("Valor que no devenga Interés más de 3 a 6 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("saldo_vencer_3_6_meses");
            entity.Property(e => e.SaldoVencer612Meses)
                .HasComment("Valor que no devenga Interés más de 6 a 12 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("saldo_vencer_6_12_meses");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion");
            entity.Property(e => e.TipoOperacion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_operacion");
            entity.Property(e => e.ValorComisionVencer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_comision_vencer");
            entity.Property(e => e.ValorDemandaJudicial)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_demanda_judicial");
            entity.Property(e => e.ValorNoDevengaInteres12masMeses)
                .HasComment("Valor que no devenga Interés más de 12 meses ")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_12mas_meses");
            entity.Property(e => e.ValorNoDevengaInteres130Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_1_30_dias");
            entity.Property(e => e.ValorNoDevengaInteres13Meses)
                .HasComment("Valor que no devenga Interés más de 1 a 3 meses ")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_1_3_meses");
            entity.Property(e => e.ValorNoDevengaInteres36Meses)
                .HasComment("Valor que no devenga Interés más de 3 a 6 meses ")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_3_6_meses");
            entity.Property(e => e.ValorNoDevengaInteres612Meses)
                .HasComment("Valor que no devenga Interés más de 6 a 12 meses ")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_6_12_meses");
            entity.Property(e => e.ValorVencido1224Meses)
                .HasComment("Valor vencido más de 12 a 24 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_12_24_meses");
            entity.Property(e => e.ValorVencido12Meses)
                .HasComment("Valor vencido más de 1 a 2 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_1_2_meses");
            entity.Property(e => e.ValorVencido130Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_1_30_dias");
            entity.Property(e => e.ValorVencido23Meses)
                .HasComment("Valor vencido más de 2 a 3 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_2_3_meses");
            entity.Property(e => e.ValorVencido2436Meses)
                .HasComment("Valor vencido más de 24 a 36 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_24_36_meses");
            entity.Property(e => e.ValorVencido36Meses)
                .HasComment("Valor vencido más de 3 a 6 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_3_6_meses");
            entity.Property(e => e.ValorVencido36masMeses)
                .HasComment("Valor vencido más de 36 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_36mas_meses");
            entity.Property(e => e.ValorVencido69Meses)
                .HasComment("Valor vencido más de 6 a 9 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_6_9_meses");
            entity.Property(e => e.ValorVencido912Meses)
                .HasComment("Valor vencido más de 9 a 12 meses")
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_vencido_9_12_meses");
        });

        modelBuilder.Entity<R05>(entity =>
        {
            entity.ToTable("R05");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("calificacion");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FormaCancelacion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("forma_cancelacion");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion");
            entity.Property(e => e.NumeroOperacion)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numero_operacion");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion");
            entity.Property(e => e.TipoTarjeta)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("tipo_tarjeta");
        });

        modelBuilder.Entity<R06Cancelado>(entity =>
        {
            entity.ToTable("R06_cancelados", tb => tb.HasComment("GARANTES Y CODEUDORES CANCELADOS"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.FechaEliminacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_eliminacion");
            entity.Property(e => e.IdentificacionCodeudor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_codeudor");
            entity.Property(e => e.IdentificacionSujeto)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_sujeto");
            entity.Property(e => e.NumeroOperacion)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numero_operacion");
            entity.Property(e => e.TipoIdentificacionDeudor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion_deudor");
            entity.Property(e => e.TipoIdentificacionSujeto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion_sujeto");
        });

        modelBuilder.Entity<R06Reportado>(entity =>
        {
            entity.ToTable("R06_reportados", tb => tb.HasComment("GARANTES Y CODEUDORES REPORTADOS EN EL MES"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.FechaCorte)
                .HasColumnType("datetime")
                .HasColumnName("fecha_corte");
            entity.Property(e => e.FechaEliminacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_eliminacion");
            entity.Property(e => e.IdentificacionCodeudor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_codeudor");
            entity.Property(e => e.IdentificacionSujeto)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_sujeto");
            entity.Property(e => e.NumeroOperacion)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numero_operacion");
            entity.Property(e => e.TipoDeudor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_deudor");
            entity.Property(e => e.TipoIdentificacionCodeudor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion_codeudor");
            entity.Property(e => e.TipoIdentificacionSujeto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion_sujeto");
        });

        modelBuilder.Entity<R20>(entity =>
        {
            entity.ToTable("R20", tb => tb.HasComment("APERTURAS DE TARJETAS DE CREDITO"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClaseTarjeta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("clase_tarjeta");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.FechaConcesion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_concesion");
            entity.Property(e => e.FechaCorte)
                .HasColumnType("datetime")
                .HasColumnName("fecha_corte");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdentificacionSujeto)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_sujeto");
            entity.Property(e => e.NumeroTarjeta)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numero_tarjeta");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion");
            entity.Property(e => e.TipoTarjeta)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("tipo_tarjeta");
            entity.Property(e => e.ValorCupo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_cupo");
        });

        modelBuilder.Entity<R21>(entity =>
        {
            entity.ToTable("R21", tb => tb.HasComment("CONSUMOS DE TARJETAS"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CapitalConsumo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_consumo");
            entity.Property(e => e.CapitalVencer12masMeses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencer_12mas_meses");
            entity.Property(e => e.CapitalVencer130Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencer_1_30_dias");
            entity.Property(e => e.CapitalVencer13Meses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencer_1_3_meses");
            entity.Property(e => e.CapitalVencer36Meses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencer_3_6_meses");
            entity.Property(e => e.CapitalVencer612Meses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencer_6_12_meses");
            entity.Property(e => e.CapitalVencido115Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencido_1_15_dias");
            entity.Property(e => e.CapitalVencido120dias9meses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencido_120dias_9meses");
            entity.Property(e => e.CapitalVencido1545Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencido_15_45_dias");
            entity.Property(e => e.CapitalVencido4590Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencido_45_90_dias");
            entity.Property(e => e.CapitalVencido90120Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencido_90_120_dias");
            entity.Property(e => e.CapitalVencido9masMeses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("capital_vencido_9mas_meses");
            entity.Property(e => e.CateraCastigada)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("catera_castigada");
            entity.Property(e => e.CodigoInstFinanciera)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("codigo_inst_financiera");
            entity.Property(e => e.CostosOperativosVencer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("costos_operativos_vencer");
            entity.Property(e => e.FechaCorte)
                .HasColumnType("datetime")
                .HasColumnName("fecha_corte");
            entity.Property(e => e.IdentificacionSujeto)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("identificacion_sujeto");
            entity.Property(e => e.NumeroTarjeta)
                .HasColumnType("numeric(22, 0)")
                .HasColumnName("numero_tarjeta");
            entity.Property(e => e.TipoCreditoOperacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_credito_operacion");
            entity.Property(e => e.TipoCreditoTarjeta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_credito_tarjeta");
            entity.Property(e => e.TipoIdentificacionSujeto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_identificacion_sujeto");
            entity.Property(e => e.TipoTarjeta)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("tipo_tarjeta");
            entity.Property(e => e.TotalCostosOperativosVencidos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("total_costos_operativos_vencidos");
            entity.Property(e => e.ValorDemandaJudicial)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_demanda_judicial");
            entity.Property(e => e.ValorNoDevengaInteres12masMeses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_12mas_meses");
            entity.Property(e => e.ValorNoDevengaInteres130Dias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_1_30_dias");
            entity.Property(e => e.ValorNoDevengaInteres13Meses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_1_3_meses");
            entity.Property(e => e.ValorNoDevengaInteres36Meses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_3_6_meses");
            entity.Property(e => e.ValorNoDevengaInteres612Meses)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("valor_no_devenga_interes_6_12_meses");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__roles__3213E83FB6F1968E");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83FF9CA9A67");

            entity.ToTable("usuarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(20)
                .HasColumnName("apellidos");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(20)
                .HasColumnName("contrasena");
            entity.Property(e => e.Correo)
                .HasMaxLength(40)
                .HasColumnName("correo");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Nombres)
                .HasMaxLength(20)
                .HasColumnName("nombres");
            entity.Property(e => e.Rol).HasColumnName("rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
