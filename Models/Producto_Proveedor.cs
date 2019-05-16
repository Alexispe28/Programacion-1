using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Models
{
    public class Producto_Proveedor{
        [Key, Column(Order=0)]
        public int Id_Producto { get; set; }
        [Key, Column(Order=1)]
        public int Id_Proveedor { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public string Fecha_de_Entrega { get; set; }
        [Required]
        public string Fecha_de_Salida { get; set; }
    }
    
}