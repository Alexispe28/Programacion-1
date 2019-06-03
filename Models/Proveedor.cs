using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
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
        public string Direccion { get; set; }
        public List<Guia_de_Remision> Guia_de_Remisions { get; set; }
    }
}
    
