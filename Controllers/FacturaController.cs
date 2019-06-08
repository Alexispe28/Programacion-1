using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Programacion_1.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Programacion_1.Models
{
    [Authorize]
    public class FacturaController : Controller
    {
        private ProyectoContext _context { get; }

        public FacturaController(ProyectoContext context) {
            _context = context;
        }
        public IActionResult Registrar(){
            ViewBag.Cliente = _context.Clientes.ToList();
            ViewBag.Producto = _context.Productos.Include(x => x.Marca).ToList();
            return View();
        }
        public JsonResult buscarCliente(int a)
        {
            Cliente cliente = _context.Clientes.Find(a);
            string[] datosCliente = new string[6];
            datosCliente[0] = cliente.Id_Cliente.ToString();
            datosCliente[1] = cliente.Nombre;
            datosCliente[2] = cliente.Apellido;
            datosCliente[3] = cliente.Correo;
            datosCliente[4] = cliente.Numero_Telefonico;
            return Json(datosCliente);
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
        public int RegistrarFacturaCliente(string fchRealizada,decimal total,int codClnt){
            Factura factura = new Factura();
            factura.Fecha_Realizada = DateTime.Parse(fchRealizada);
            factura.Id_Cliente = codClnt;
            factura.Total = total;
            _context.Facturas.Add(factura);
            _context.SaveChanges();
            return _context.Facturas.Last().Id_Factura;
        }
         public void RegistrarInventario(int id_Factura)
         {
             var Items = _context.Factura_Items
            .Where(x => x.Id_Factura == id_Factura).ToList();
             List<Inventario> inventarios = new List<Inventario>();
             foreach(var e in Items){
                Inventario inventario = new Inventario();
                inventario.Id_Producto = e.Id_Producto;
                inventario.Cantidad_Total = -e.Cantidad;
                inventarios.Add(inventario);
             }
             _context.Inventarios.AddRange(inventarios);
             _context.SaveChanges();
         }
        public JsonResult registrarFactura(string row, string fchRealizada, string codClnt,string total)
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
            try{
                for(int i = 0; i < codigo.Count() - 1; i++){
                    if(int.Parse(cantidad[i]) > _context.Inventarios.Where(x => x.Id_Producto == int.Parse(codigo[i])).Sum(y => y.Cantidad_Total)){
                        return Json("El producto " + _context.Inventarios.Include(p => p.Producto).FirstOrDefault(x => x.Id_Producto == int.Parse(codigo[i])).Producto.Nombre + " no se encuentra.");
                    }
                }
            }catch(Exception ){
                return Json("Uno de los productos no existe en el inventarios. Verifique cual productos hay en el Inventarios.");
            }
            List<Factura_Item> Factura_Item = new List<Factura_Item>();
            decimal ValorTotal = 0;
            for(int i = 0; i < codigo.Count() - 1; i++){
                ValorTotal += decimal.Parse(subtotal[i]);
            }
            int id_Factura = RegistrarFacturaCliente(fchRealizada,ValorTotal,int.Parse(codClnt));
            for(int i = 0; i < codigo.Count() - 1; i++)
            {
                Factura_Item Factura_Item1 = new Factura_Item();
                Factura_Item1.Id_Producto = int.Parse(codigo[i]);
                Factura_Item1.Id_Factura = id_Factura;
                Factura_Item1.Cantidad = int.Parse(cantidad[i]);
                Factura_Item1.Subtotal = decimal.Parse(subtotal[i]);
                Factura_Item.Add(Factura_Item1);
            }
            _context.Factura_Items.AddRange(Factura_Item);
            _context.SaveChanges();
            RegistrarInventario(id_Factura);
            return Json("Se ha registrado.");
        }
        public IActionResult Listar()
        {
            var Facturas = _context.Facturas.Include(x => x.Cliente).ToList();
            return View(Facturas);
        }
        public IActionResult Detalles(int id)
        {
            var p = _context.Facturas.Include(s => s.Cliente).FirstOrDefault(x => x.Id_Factura == id);
            
            if (p == null) {
                return NotFound();
            }
            ViewBag.Factura_Items = _context.Factura_Items.Include(m => m.Producto)
            .Where(x => x.Id_Factura == id).ToList();
            return View(p);
        }
        //Eliminar
        public IActionResult Eliminar(int id)
        {
            var c = _context.Facturas.FirstOrDefault(x => x.Id_Factura == id);
            return View(c);
        }
        [HttpPost]
        public IActionResult Eliminar(Factura f)
        {
            if (f != null) {
                var facturaItems = _context.Factura_Items.Where(x => x.Id_Factura == f.Id_Factura);
                List<Inventario> inventario = new List<Inventario>();
                foreach(var e in facturaItems){
                    Inventario inv = new Inventario();
                    inv.Id_Producto = e.Id_Producto;
                    inv.Cantidad_Total = e.Cantidad;
                    inventario.Add(inv);
                }
                _context.AddRange(inventario);
                _context.SaveChanges();
                _context.Facturas.Remove(f);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}