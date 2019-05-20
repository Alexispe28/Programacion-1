using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programacion_1.Models;

namespace Programacion_1.Controllers
{
    public class MarcaController : Controller
    {
       private ProyectoContext _context { get; }

        public MarcaController(ProyectoContext context) {
            _context = context;
        }
        //Mostrar Lista
        public IActionResult Listar()
        {
            var marca = _context.Marcas.ToList();

            return View(marca);
        }
        //Registrar
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Marca m)
        {
            if (ModelState.IsValid) {
                _context.Marcas.Add(m);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(m);
        }
        //Actualizar
        public IActionResult Actualizar(int id)
        {
            var p = _context.Marcas.FirstOrDefault(x => x.Id_Marca == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(Marca m)
        {
            if (ModelState.IsValid) {
                var proveedorBd = _context.Marcas.Find(m.Id_Marca);

                proveedorBd.Nombre = m.Nombre;
                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(m);
        }
        //Eliminar
        public IActionResult Eliminar(int id)
        {
            var p = _context.Marcas.FirstOrDefault(x => x.Id_Marca == id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Eliminar(Marca m)
        {
            if (m != null) {
                _context.Marcas.Remove(m);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}