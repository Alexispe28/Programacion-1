using Microsoft.EntityFrameworkCore;

namespace Programacion_1.Models
{
    public class ProyectoContext: DbContext
    {
        public DbSet<Producto> Productos { get; set; } 
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; } 
        public ProyectoContext(DbContextOptions<ProyectoContext> options):base(options){}
    }
}