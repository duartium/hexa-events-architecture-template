
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fluxeen.HexagonalEventDriven.Domain.Catalogs.Entities;

namespace Fluxeen.HexagonalEventDriven.Domain.Structures.Entities;
public class R05 : Catalogo_Base
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
    public int Tipo_Tarjeta { get; set; }

    [Required]
    [StringLength(2, MinimumLength = 2)]
    public string Forma_Cancelacion { get; set; }

    [Required]
    public DateTime Fecha_Cancelacion { get; set; }

    [Required]
    [StringLength(1, MinimumLength = 1)]
    public string Clasificacion { get; set; }
}