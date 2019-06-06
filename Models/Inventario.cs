using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Inventario
    {
        [Key]
        public int Id_Inventario { get; set; }
        [Required]
        public int Id_Producto { get; set; }
        public Producto Producto { get; set; }
        [Required]
        public int Cantidad_Total { get; set; }
    }
}