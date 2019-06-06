using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programacion_1.Models;

namespace Programacion_1.Controllers
{
    public class ClienteController : Controller
    {
       private ProyectoContext _context { get; }

        public ClienteController(ProyectoContext context) {
            _context = context;
        }
        //Mostrar Lista
        public IActionResult Listar()
        {
            var cliente = _context.Clientes.ToList();

            return View(cliente);
        }
        //Registrar
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Cliente c)
        {
            if (ModelState.IsValid) {
                _context.Clientes.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(c);
        }
        //Actualizar
        public IActionResult Actualizar(int id)
        {
            var c = _context.Clientes.FirstOrDefault(x => x.Id_Cliente == id);

            if (c == null) {
                return NotFound();
            }

            return View(c);
        }

        [HttpPost]
        public IActionResult Actualizar(Cliente c)
        {
            if (ModelState.IsValid) {
                var clienteBd = _context.Clientes.Find(c.Id_Cliente);

                clienteBd.Nombre = c.Nombre;
                clienteBd.Apellido = c.Apellido;
                clienteBd.Correo = c.Correo;
                clienteBd.Numero_Telefonico = c.Numero_Telefonico;

                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(c);
        }
        //Eliminar
        public IActionResult Eliminar(int id)
        {
            var c = _context.Clientes.FirstOrDefault(x => x.Id_Cliente == id);
            return View(c);
        }
        [HttpPost]
        public IActionResult Eliminar(Cliente c)
        {
            if (c != null) {
                _context.Clientes.Remove(c);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}