using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Programacion_1.Models
{
    public class ProyectoContext: IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; } 
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; } 
        public DbSet<Marca> Marcas { get; set; } 
        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<Factura> Facturas { get; set; } 
         public DbSet<Factura_Item> Factura_Items { get; set; } 
        public DbSet<Guia_de_Remision_Item> Guia_de_Remision_Items { get; set; }
        public DbSet<Guia_de_Remision> Guia_de_Remisions { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public ProyectoContext(DbContextOptions<ProyectoContext> options):base(options){
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Foreign Key Producto
            modelBuilder.Entity<Producto>().HasOne<Categoria>(s => s.Categoria)
            .WithMany(p => p.Productos).HasForeignKey(p => p.Id_Categoria);
            modelBuilder.Entity<Producto>().HasOne<Marca>(s => s.Marca)
            .WithMany(p => p.Productos).HasForeignKey(p => p.Id_Marca);

            //Foreign Key Inventario
            modelBuilder.Entity<Inventario>().HasOne<Producto>(s => s.Producto)
            .WithMany(p => p.Inventarios).HasForeignKey(p => p.Id_Producto);

            //Foreign Key Guia_de_Remision_Item
            modelBuilder.Entity<Guia_de_Remision_Item>().HasOne<Producto>(s => s.Producto)
            .WithMany(p => p.Guia_de_Remision_Items).HasForeignKey(p => p.Id_Producto);

            modelBuilder.Entity<Guia_de_Remision_Item>().HasOne<Guia_de_Remision>(s => s.Guia_de_Remision)
            .WithMany(p => p.Guia_de_Remision_Items).HasForeignKey(p => p.Id_Guia_de_Remision);
            
            //Foreign Key Guia_de_Remision
            modelBuilder.Entity<Guia_de_Remision>().HasOne<Proveedor>(s => s.Proveedor)
            .WithMany(p => p.Guia_de_Remisions).HasForeignKey(p => p.Id_Proveedor);
            
            //Foreign Key Factura
            modelBuilder.Entity<Factura>().HasOne<Cliente>(s => s.Cliente)
            .WithMany(p => p.Facturas).HasForeignKey(p => p.Id_Cliente);
            
            //Foreign Key Factura_Item
            modelBuilder.Entity<Factura_Item>().HasOne<Factura>(s => s.Factura)
            .WithMany(p => p.Factura_Items).HasForeignKey(p => p.Id_Factura_Item);
            modelBuilder.Entity<Factura_Item>().HasOne<Producto>(s => s.Producto)
            .WithMany(p => p.Factura_Items).HasForeignKey(p => p.Id_Producto);
        }
    }
}