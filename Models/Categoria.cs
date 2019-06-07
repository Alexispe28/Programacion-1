using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programacion_1.Models
{
    public class Categoria{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Categoria { get; set; }
        [Required]
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
    
}