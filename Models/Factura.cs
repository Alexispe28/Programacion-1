using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Factura{
        [Key]
        public int Id_Factura { get; set; }
        [Required]
        public string Fecha_Realizada { get; set; }
        public decimal Total { get; set; }
        [Required]
        public int Id_Cliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<Factura_Item> Factura_Items { get; set; }
    }
    
}