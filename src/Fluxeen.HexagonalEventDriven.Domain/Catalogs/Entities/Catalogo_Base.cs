using System.ComponentModel.DataAnnotations;

namespace Fluxeen.HexagonalEventDriven.Domain.Catalogs.Entities;
public class Catalogo_Base
{
    [Required]
    [MaxLength(30)]
    public string Usuarion_Creacion { get; set; }

    [Required]
    public DateTime Fecha_Creacion { get; set; }

    [MaxLength(30)]
    public string Usuario_Modificacion { get; set; }
    public DateTime Fecha_Modificacion { get; set; }

    [MaxLength(30)]
    public string Usuario_Eliminacion { get; set; }
    public DateTime Fecha_Eliminacion { get; set; }
}