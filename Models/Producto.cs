using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Producto{
        [Key]
        public int Id_Producto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Precio { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Marca { get; set; }
    }
    
}