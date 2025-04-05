namespace Administracion.Models
{
    public class Combo
    {
        public int ComboID { get; set; }
        public string Nombre { get; set; } = null!; public string? Descripcion { get; set; }
        public string? ImagenURL { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

}