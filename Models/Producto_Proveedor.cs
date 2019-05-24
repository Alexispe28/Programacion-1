using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programacion_1.Models
{
    public class Producto_Proveedor{
        [Key]
        public int Id_Producto { get; set; }
        public Producto Producto { get; set; }
        [Key]
        public int Id_Proveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public string Fecha_de_Entrega { get; set; }
        [Required]
        public string Fecha_de_Salida { get; set; }
    }
    
}