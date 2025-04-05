namespace Administracion.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int? Plato_Id { get; set; }
        public Plato? Plato { get; set; }
    }
}
