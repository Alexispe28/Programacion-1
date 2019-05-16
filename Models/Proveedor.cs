using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Proveedor{
        [Key]
        public int Id_Proveedor { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Numero_Telefonico { get; set; }
        [Required]
        public string Detalles { get; set; }
        public int Id_Direccion { get; set; }
    }
}
    
