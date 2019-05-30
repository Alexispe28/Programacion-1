using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class GuiaDeRemision{
        [Key]
        public int Id_Guia_Remision { get; set; }
        public DateTime Fecha_de_Llegada { get; set; }
        public decimal Total { get; set; }
        public List<Inventario> Inventarios  { get; set; }
    }
    
}