using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programacion_1.Models;

namespace Programacion_1.Controllers
{
    public class ProveedorController : Controller
    {
       private ProyectoContext _context { get; }

        public ProveedorController(ProyectoContext context) {
            _context = context;
        }
        //Mostrar Lista
        public IActionResult Listar()
        {
            var proveedor = _context.Proveedors.ToList();

            return View(proveedor);
        }
        //Registrar
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Proveedor p)
        {
            if (ModelState.IsValid) {
                _context.Proveedors.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(p);
        }
        //Actualizar
        public IActionResult Actualizar(int id)
        {
            var p = _context.Proveedors.FirstOrDefault(x => x.Id_Proveedor == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(Proveedor p)
        {
            if (ModelState.IsValid) {
                var proveedorBd = _context.Proveedors.Find(p.Id_Proveedor);

                proveedorBd.Nombre = p.Nombre;
                proveedorBd.Correo = p.Correo;
                proveedorBd.Numero_Telefonico = p.Numero_Telefonico;
                proveedorBd.Detalles = p.Detalles;
                proveedorBd.Direccion = p.Direccion;

                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }
        //Eliminar
        public IActionResult Eliminar(int id)
        {
            var p = _context.Proveedors.FirstOrDefault(x => x.Id_Proveedor == id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Eliminar(Proveedor p)
        {
            if (p != null) {
                _context.Proveedors.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}