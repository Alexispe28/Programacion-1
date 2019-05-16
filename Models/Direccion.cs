using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Direccion{
        [Key]
        public int Id_Direccion { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
    
}