using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fluxeen.HexagonalEventDriven.Domain.Catalogs.Entities;

namespace Fluxeen.HexagonalEventDriven.Domain.RStructures.Entities
{
    public class R02 : Catalogo_Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Codigo_Inst_Financiera { get; set; }

        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string Tipo_Identificacion_Sujeto { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string Identificacion_Sujeto { get; set; }

        [Required]
        [StringLength(22, MinimumLength = 22)]
        public string Numero_Operacion { get; set; }

        [Required]
        public DateTime Fecha_Corte { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string Tipo_Credito { get; set; }

        [Required]
        public DateTime Fecha_Concesion { get; set; }

        [Required]
        public DateTime Fecha_Vencimiento { get; set; }

        [Required]
        [Column(TypeName = "numeric(15,2)")]
        public decimal Valor_Operacion { get; set; }

        [Required]
        public DateTime Fecha_Cancelacion { get; set; }
    }
}
