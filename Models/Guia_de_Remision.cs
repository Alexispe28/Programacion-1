using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Guia_de_Remision{
        [Key]
        public int Id_Guia_de_Remision { get; set; }
        [Required]
        public int Id_Proveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime Fecha_de_Llegada { get; set; }
        public decimal Total { get; set; }
        public List<Guia_de_Remision_Item> Guia_de_Remision_Items  { get; set; }
    }
    
}