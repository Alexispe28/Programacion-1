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
        [Required]
        public int Id_Categoria { get; set; }
        public Categoria Categoria { get; set; }
        [Required]
        public int Id_Marca { get; set; }
        public Marca Marca { get; set; }
        public List<Guia_de_Remision_Item> Guia_de_Remision_Items { get; set; }
        public List<Inventario> Inventarios { get; set; }
        public List<Factura_Item> Factura_Items { get; set; }
    }
    
}