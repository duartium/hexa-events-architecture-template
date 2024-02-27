using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fluxeen.HexagonalEventDriven.Domain.Catalogs.Enums;

namespace Fluxeen.HexagonalEventDriven.Domain.Catalogs.Entities;
public class Catalogo : Catalogo_Base
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Codigo { get; set; }

    [Required]
    [MaxLength(200)]
    public string Nombre { get; set; }

    [MaxLength(300)]
    public string Descripcion { get; set; }

    [Required]
    [MaxLength(30)]
    public EstadoEnum Estado { get; set; }
}
