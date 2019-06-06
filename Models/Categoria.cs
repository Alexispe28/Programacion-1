using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Categoria{
        [Key]
        public int Id_Categoria { get; set; }
        [Required]
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
    
}