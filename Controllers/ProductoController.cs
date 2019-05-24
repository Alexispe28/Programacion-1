using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programacion_1.Models;
namespace Programacion_1.Controllers
{
    public class ProductoController : Controller
    {
       private ProyectoContext _context { get; }

        public ProductoController(ProyectoContext context) {
            _context = context;
        }
        //Mostrar Lista
        public IActionResult Listar()
        {
            var marca = _context.Productos.ToList();

            return View(marca);
        }
        //Registrar
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Producto p)
        {
            if (ModelState.IsValid) {
                _context.Productos.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(p);
        }
        //Actualizar
        public IActionResult Actualizar(int id)
        {
            var p = _context.Productos.FirstOrDefault(x => x.Id_Producto == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(Producto p)
        {
            if (ModelState.IsValid) {
                var productoBd = _context.Productos.Find(p.Id_Producto);
                productoBd.Id_Producto=p.Id_Producto;
                productoBd.Nombre = p.Nombre;
                productoBd.Precio=p.Precio;
                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }
        //Eliminar
        public IActionResult Eliminar(int id)
        {
            var p = _context.Productos.FirstOrDefault(x => x.Id_Producto == id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Eliminar(Producto p)
        {
            if (p != null) {
                _context.Productos.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}