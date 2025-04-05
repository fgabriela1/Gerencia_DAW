namespace Administracion.Models
{
    public class Promocion
    {
        public int PromocionID { get; set; }
        public string Descripcion { get; set; } = null!; public decimal Descuento { get; set; }
        public string? ImagenURL { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}