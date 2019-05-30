using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programacion_1.Models
{
    public class Inventario{
        [Key]
        public int Id_Inventario { get; set; }
        [Required]
        public int Id_Guia_Remision { get; set; }
        public GuiaDeRemision GuiaDeRemision { get; set; }
        [Required]
        public int Id_Producto { get; set; }
        public Producto Producto { get; set; }
        [Required]
        public int Id_Proveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal subTotal { get; set; }

    }
    
}