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
            //Foreign Key Producto
            modelBuilder.Entity<Producto>().HasOne<Categoria>(s => s.Categoria)
            .WithMany(p => p.Productos).HasForeignKey(p => p.Id_Categoria);
            modelBuilder.Entity<Producto>().HasOne<Marca>(s => s.Marca)
            .WithMany(p => p.Productos).HasForeignKey(p => p.Id_Marca);
            //Foreign Key Producto_Proveedor
            modelBuilder.Entity<Producto_Proveedor>().HasOne<Producto>(s => s.Producto)
            .WithMany(p => p.Producto_Proveedores).HasForeignKey(p => p.Id_Producto);
            modelBuilder.Entity<Producto_Proveedor>().HasOne<Proveedor>(s => s.Proveedor)
            .WithMany(p => p.Producto_Proveedores).HasForeignKey(p => p.Id_Proveedor);
        }
    }
}