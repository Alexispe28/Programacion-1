using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programacion_1.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

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
         public JsonResult buscarProveedor(int a)
        {
            Proveedor proveedor = _context.Proveedors.Find(a);
            string[] datosProveedor = new string[4];
            datosProveedor[0] = proveedor.Id_Proveedor.ToString();
            datosProveedor[1] = proveedor.Nombre;
            datosProveedor[2] = proveedor.Correo;
            datosProveedor[3] = proveedor.Direccion;
            return Json(datosProveedor);
        }
        public JsonResult buscarProducto(int b)
        {
            Producto producto = _context.Productos.Find(b);
            Marca marca = _context.Marcas.Find(producto.Id_Marca);
            Categoria categoria = _context.Categorias.Find(producto.Id_Categoria);
            string[] datosProducto = new string[5];
            datosProducto[0] = producto.Id_Producto.ToString();
            datosProducto[1] = producto.Nombre;
            datosProducto[2] = marca.Nombre.ToString();
            datosProducto[3] = categoria.Nombre.ToString();
            datosProducto[4] = producto.Precio.ToString();
            return Json(datosProducto);
        }
        public int RegistrarGuia(string fchLlegada,decimal total){
            GuiaDeRemision guiaRemision = new GuiaDeRemision();
            guiaRemision.Fecha_de_Llegada = DateTime.Parse(fchLlegada);
            guiaRemision.Total = total;
            _context.GuiaDeRemisions.Add(guiaRemision);
            _context.SaveChanges();
            return _context.GuiaDeRemisions.FirstOrDefault(x => x.Fecha_de_Llegada == guiaRemision.Fecha_de_Llegada).Id_Guia_Remision;
        }
        public JsonResult registrarInventario(string row, string fchLlegada, string codProv,string total)
        {
            var stringifiedTable = row.Split('-');
            List<string> codigo = new List<string>();
            List<string> cantidad = new List<string>();
            List<string> subtotal = new List<string>();
            for (int i = 0; i < stringifiedTable.Count(); i += 5)
            {
                codigo.Add(stringifiedTable[i]);
            }
            for(int i = 2; i < stringifiedTable.Count(); i+=5)
            {
                cantidad.Add(stringifiedTable[i]);
            }
            for (int i = 4; i < stringifiedTable.Count(); i+=5)
            {
                subtotal.Add(stringifiedTable[i]);
            }
            List<Inventario> inventario = new List<Inventario>();
            decimal ValorTotal = 0;
            for(int i = 0; i < codigo.Count() - 1; i++){
                ValorTotal += decimal.Parse(subtotal[i])/100;
            }
            int id_Guia_Remision = RegistrarGuia(fchLlegada,ValorTotal);
            for(int i = 0; i < codigo.Count() - 1; i++)
            {
                Inventario inventario1 = new Inventario();
                inventario1.Id_Producto = int.Parse(codigo[i]);
                inventario1.Id_Proveedor = int.Parse(codProv);
                inventario1.Id_Guia_Remision = id_Guia_Remision;
                inventario1.Cantidad = int.Parse(cantidad[i]);
                inventario1.subTotal = decimal.Parse(subtotal[i])/100;
                inventario.Add(inventario1);
            }
            _context.Inventarios.AddRange(inventario);
            _context.SaveChanges();
            return Json("Se ha registrado");
        }
    }
}