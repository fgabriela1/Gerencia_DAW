using System.ComponentModel.DataAnnotations;

namespace Administracion.Models
{
    public class DetallePedido
    {
        [Key]
        public int Id_pedido { get; set; }
        public int Id_menu { get; set; }
    }
}