using Microsoft.EntityFrameworkCore;
using Zapateria.Models;

namespace Zapateria.Data
{
    public class ZapateriaDbContext : DbContext
    {
        public ZapateriaDbContext(DbContextOptions<ZapateriaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<DetalleVenta> DetalleVentas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta>()
                .Property(v => v.Total)
                .HasPrecision(18, 2);

            modelBuilder.Entity<DetalleVenta>()
                .Property(d => d.Precio)
                .HasPrecision(18, 2);
        }
    }
}