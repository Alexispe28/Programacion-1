using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Cliente{
        [Key]
        public int Id_Cliente { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Numero_Telefonico { get; set; }
        public List<Factura> Facturas { get; set; }
    }
    
}