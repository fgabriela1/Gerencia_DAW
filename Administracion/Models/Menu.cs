namespace Administracion.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string Nombre { get; set; } = null!; 
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set;}
    }
}