
using System.ComponentModel.DataAnnotations;

public class Empleado
{
    [Key]
    public int EmpleadoID { get; set; }

    public string UrlFotoEmpleado { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Apellido { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public string Telefono { get; set; }

    [Required]
    public string Contrasena { get; set; }

    public int? RolID { get; set; }

    public DateTime FechaIngreso { get; set; }
}
