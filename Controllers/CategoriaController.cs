using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programacion_1.Models;

namespace Programacion_1.Controllers
{
    public class CategoriaController : Controller
    {
       private ProyectoContext _context { get; }

        public CategoriaController(ProyectoContext context) {
            _context = context;
        }
        //Mostrar Lista
        public IActionResult Listar()
        {
            var categoria = _context.Categorias.ToList();

            return View(categoria);
        }
        //Registrar
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Categoria c)
        {
            if (ModelState.IsValid) {
                _context.Categorias.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(c);
        }
        //Actualizar
        public IActionResult Actualizar(int id)
        {
            var p = _context.Categorias.FirstOrDefault(x => x.Id_Categoria == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(Categoria c)
        {
            if (ModelState.IsValid) {
                var proveedorBd = _context.Categorias.Find(c.Id_Categoria);

                proveedorBd.Nombre = c.Nombre;

                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(c);
        }
        //Eliminar
        public IActionResult Eliminar(int id)
        {
            var c = _context.Categorias.FirstOrDefault(x => x.Id_Categoria == id);
            return View(c);
        }
        [HttpPost]
        public IActionResult Eliminar(Categoria c)
        {
            if (c != null) {
                _context.Categorias.Remove(c);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}