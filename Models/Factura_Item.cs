using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Factura_Item{
        [Key]
        public int Id_Factura_Item { get; set; }
        [Required]
        public int Id_Factura { get; set; }
        public Factura Factura { get; set; }
        [Required]
        public int Id_Producto { get; set; }
        public Producto Producto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Subtotal { get; set; }
        
    }
    
}