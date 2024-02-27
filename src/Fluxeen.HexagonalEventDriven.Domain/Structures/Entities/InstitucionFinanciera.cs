using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluxeen.HexagonalEventDriven.Domain.Structures.Entities;

[Table("Institucion_Financiera")]
public class InstitucionFinanciera
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
}