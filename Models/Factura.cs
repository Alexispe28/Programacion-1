using System.ComponentModel.DataAnnotations;

namespace Programacion_1.Models
{
    public class Factura{
        [Key]
        public int Id_Factura { get; set; }
        [Required]
        public int Cantidad { get; set; }
        public string Fecha_Realizada { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Cliente { get; set; }
    }
    
}