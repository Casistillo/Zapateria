using System.Net.Http.Json;
using Zapateria.Models;

namespace Zapateria.Services
{
    public class ProductoService
    {
        private readonly HttpClient _http;

        public ProductoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ProductoApi>> ObtenerProductos()
        {
            try
            {
                var productos = await _http.GetFromJsonAsync<List<ProductoApi>>
                (
                    "https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net/api/comercio/productos"
                );

                return productos?
                    .Where(p => p.Categoria == "Calzado")
                    .ToList()
                    ?? new List<ProductoApi>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error API: {ex.Message}");

                return new List<ProductoApi>();
            }
        }
        public async Task<List<CategoriaApi>> ObtenerCategorias()
        {
            try
            {
                var categorias = await _http.GetFromJsonAsync<List<CategoriaApi>>
                (
                    "https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net/api/comercio/categorias"
                );

                return categorias ?? new List<CategoriaApi>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consumir categorías: {ex.Message}");
                return new List<CategoriaApi>();
            }
        }
    }
}