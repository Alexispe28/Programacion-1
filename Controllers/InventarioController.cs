using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programacion_1.Models;
using Newtonsoft.Json;

namespace Programacion_1.Models
{
    public class InventarioController : Controller
    {
        private ProyectoContext _context { get; }

        public InventarioController(ProyectoContext context) {
            _context = context;
        }
        public IActionResult Registrar(){
            ViewBag.Proveedor = _context.Proveedors.ToList();
            ViewBag.Producto = _context.Productos.ToList();
            return View();
        }
    }
}