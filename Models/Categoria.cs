using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Categoria{
        [Key]
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
    
}