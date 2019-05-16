using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Marca{
        [Key]
        public int Id_Marca { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
    
}