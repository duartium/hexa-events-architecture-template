
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fluxeen.HexagonalEventDriven.Domain.Catalogs.Entities;

namespace Fluxeen.HexagonalEventDriven.Domain.RStructures.Entities
{
    public class R04 : Catalogo_Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Codigo_Inst_Financiera { get; set; }

        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string Tipo_Identificacion { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(22, MinimumLength = 22)]
        public string Numero_Operacion { get; set; }

        [Required]
        public DateTime Fecha_Corte { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Saldo_Vencer_1_30_dias { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Saldo_Vencer_1_3_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Saldo_Vencer_3_6_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Saldo_Vencer_6_12_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Saldo_Vencer_12mas_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Comision_vencer { get; set; }
        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal saldo_vencer_1_3_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_No_Devenga_Interes_1_30_dias { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_No_Devenga_Interes_1_3_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_No_Devenga_Interes_3_6_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_No_Devenga_Interes_6_12_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_No_Devenga_Interes_12mas_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_1_30_dias { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_1_2_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_2_3_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_3_6_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_6_9_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_9_12_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_12_24_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_24_36_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Vencido_36mas_meses { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Demanda_Judicial { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Cartera_Castigada { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string Tipo_Operacion { get; set; }

        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string Estado_Operacion { get; set; }
    }
}
