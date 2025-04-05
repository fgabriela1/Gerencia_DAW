namespace Administracion.Models
{
    public class MetodosPago { 
        public int MetodoID { get; set; } 
        public string Nombre { get; set; } = null!; 
        public string? Descripcion { get; set; } 
    }
}