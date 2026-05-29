using System.ComponentModel.DataAnnotations;

namespace Zapateria.Models
{
    public class DetalleVenta
    {
        [Key]
        public int Id { get; set; }

        public int VentaId { get; set; }

        public Venta? Venta { get; set; }

        public int ProductoApiId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Subtotal => Cantidad * Precio;
    }
}