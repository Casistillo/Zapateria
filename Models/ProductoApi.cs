namespace Zapateria.Models
{
    public class ProductoApi
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string Categoria { get; set; } = string.Empty;

        public string Proveedor { get; set; } = string.Empty;

        public int CategoriaId { get; set; }

        public int ProveedorId { get; set; }
    }
}