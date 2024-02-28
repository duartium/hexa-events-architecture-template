using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fluxeen.HexagonalEventDriven.Domain.Catalogs.Entities;

namespace Fluxeen.HexagonalEventDriven.Domain.RStructures.Entities
{
    [Table("Sujetos_Riesgo")]
    public class R01 : Catalogo_Base
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
        [MaxLength(200)]
        public string Nombre_Sujeto { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 4)]
        public string Causal_Vinculacion { get; set; }

        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string Clase_Sujeto { get; set; }

    }
}