using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programacion_1.Models
{
    public class Factura{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Factura { get; set; }
        [Required]
        public DateTime Fecha_Realizada { get; set; }
        public decimal Total { get; set; }
        [Required]
        public int Id_Cliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<Factura_Item> Factura_Items { get; set; }
    }
    
}