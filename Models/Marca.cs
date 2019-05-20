using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Marca{
        [Key]
        public int Id_Marca { get; set; }
        [Required]
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
    
}