using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Categoria{
        [Key]
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
    }
    
}