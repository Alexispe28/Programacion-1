using Microsoft.EntityFrameworkCore;

namespace Programacion_1.Models
{
    public class ProyectoContext: DbContext
    {
        public DbSet<Producto> Productos { get; set; } 
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; } 
        public DbSet<Marca> Marcas { get; set; } 
        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<Factura> Facturas { get; set; } 
        public DbSet<Producto_Proveedor> Producto_Proveedors { get; set; } 
        public ProyectoContext(DbContextOptions<ProyectoContext> options):base(options){
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Producto_Proveedor>()
            .HasKey(c => new { c.Id_Producto, c.Id_Proveedor });
        }
    }
}