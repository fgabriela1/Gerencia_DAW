namespace Administracion.Models
{
    public class Plato
    {
        public int PlatoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? ImagenURL { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
