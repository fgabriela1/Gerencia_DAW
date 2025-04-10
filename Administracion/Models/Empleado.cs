namespace Administracion.Models
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string? UrlFotoEmpleado { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefono { get; set; }
        public string Contrasena { get; set; } = null!;
        public int? RolID { get; set; }
        public Roles? Rol { get; set; }
        public DateTime FechaIngreso { get; set; }


    }
}