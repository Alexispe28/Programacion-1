using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Producto{
        [Key]
        public int Id_Producto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Precio { get; set; }
        public int Id_Categoria { get; set; }
        public Categoria Categoria { get; set; }
        public int Id_Marca { get; set; }
        public Marca Marca { get; set; }
        public List<Producto_Proveedor> Producto_Proveedores { get; set; }
    }
    
}