using System.ComponentModel.DataAnnotations;

namespace Zapateria.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public decimal Total { get; set; }

        public string Estado { get; set; } = "Registrada";

        public List<DetalleVenta> Detalles { get; set; } = new();
    }
}