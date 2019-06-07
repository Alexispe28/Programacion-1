using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programacion_1.Models
{
    public class Guia_de_Remision_Item{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Guia_de_Remision_Item { get; set; }
        [Required]
        public int Id_Guia_de_Remision { get; set; }
        public Guia_de_Remision Guia_de_Remision { get; set; }
        [Required]
        public int Id_Producto { get; set; }
        public Producto Producto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal subTotal { get; set; }

    }
    
}