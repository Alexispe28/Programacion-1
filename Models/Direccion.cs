using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Direccion{
        [Key]
        public int Id_Direccion { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
    
}