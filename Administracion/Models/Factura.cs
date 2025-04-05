namespace Administracion.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int Pedido_Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}