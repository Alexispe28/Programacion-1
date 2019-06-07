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
    public class InventarioController : Controller
    {
        private ProyectoContext _context { get; }

        public InventarioController(ProyectoContext context) {
            _context = context;
        }
        public IActionResult Registrar(){
            ViewBag.Proveedor = _context.Proveedors.ToList();
            ViewBag.Producto = _context.Productos.Include(x => x.Marca).ToList();
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
        public int RegistrarGuia(string fchLlegada,decimal total,int codProv){
            Guia_de_Remision guiaRemision = new Guia_de_Remision();
            guiaRemision.Fecha_de_Llegada = DateTime.Parse(fchLlegada);
            guiaRemision.Id_Proveedor = codProv;
            guiaRemision.Total = total;
            _context.Guia_de_Remisions.Add(guiaRemision);
            _context.SaveChanges();
            return _context.Guia_de_Remisions.Last().Id_Guia_de_Remision;
        }
         public void RegistrarInventario(int id_Guia_de_Remision)
         {
             var Items = _context.Guia_de_Remision_Items
            .Where(x => x.Id_Guia_de_Remision == id_Guia_de_Remision).ToList();
             List<Inventario> inventarios = new List<Inventario>();
             foreach(var e in Items){
                Inventario inventario = new Inventario();
                inventario.Id_Producto = e.Id_Producto;
                inventario.Cantidad_Total = e.Cantidad;
                inventarios.Add(inventario);
             }
             _context.Inventarios.AddRange(inventarios);
             _context.SaveChanges();
         }
        public JsonResult registrarGuiaRemision(string row, string fchLlegada, string codProv,string total)
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
            List<Guia_de_Remision_Item> GuiadeRemisionItem = new List<Guia_de_Remision_Item>();
            decimal ValorTotal = 0;
            for(int i = 0; i < codigo.Count() - 1; i++){
                ValorTotal += decimal.Parse(subtotal[i]);
            }
            int id_Guia_de_Remision = RegistrarGuia(fchLlegada,ValorTotal,int.Parse(codProv));
            for(int i = 0; i < codigo.Count() - 1; i++)
            {
                Guia_de_Remision_Item Guia_de_Remision_Item1 = new Guia_de_Remision_Item();
                Guia_de_Remision_Item1.Id_Producto = int.Parse(codigo[i]);
                Guia_de_Remision_Item1.Id_Guia_de_Remision = id_Guia_de_Remision;
                Guia_de_Remision_Item1.Cantidad = int.Parse(cantidad[i]);
                Guia_de_Remision_Item1.subTotal = decimal.Parse(subtotal[i]);
                GuiadeRemisionItem.Add(Guia_de_Remision_Item1);
            }
            _context.Guia_de_Remision_Items.AddRange(GuiadeRemisionItem);
            _context.SaveChanges();
            RegistrarInventario(id_Guia_de_Remision);
            return Json("Se ha registrado");
        }
        public IActionResult Listar()
        {
            var GuiaDeRemisions = _context.Guia_de_Remisions.Include(x => x.Proveedor).ToList();
            return View(GuiaDeRemisions);
        }
        public IActionResult Detalles(int id)
        {
            var p = _context.Guia_de_Remisions.Include(s => s.Proveedor).FirstOrDefault(x => x.Id_Guia_de_Remision == id);
            
            if (p == null) {
                return NotFound();
            }
            ViewBag.Guia_de_Remision_Items = _context.Guia_de_Remision_Items.Include(m => m.Producto)
            .Where(x => x.Id_Guia_de_Remision == id).ToList();
            return View(p);
        }
        public IActionResult VerInventario()
        {
            //int producto = _context.Inventarios.Include(y => y.Producto).Select(x => x.Id_Producto).Distinct().Count();
            List<Inventario> inv = new List<Inventario>();
            //for(int i = 0; i < producto;i++){
            foreach(var e in _context.Inventarios.Include(x => x.Producto).ToList())
            {
                Inventario inventario = new Inventario();
                inventario.Producto = _context.Productos.Find(e.Id_Producto);
                inventario.Cantidad_Total = _context.Inventarios.Where(a => a.Id_Producto == e.Id_Producto).Sum(m => m.Cantidad_Total);
                if(inv.FirstOrDefault(x => x.Producto == e.Producto) == null){
                    inv.Add(inventario);
                }
            }
            return View(inv);
        }
        //Eliminar
        public IActionResult Eliminar(int id)
        {
            var c = _context.Guia_de_Remisions.FirstOrDefault(x => x.Id_Guia_de_Remision == id);
            return View(c);
        }
        [HttpPost]
        public IActionResult Eliminar(Guia_de_Remision g)
        {
            if (g != null) {
                var guiaItems = _context.Guia_de_Remision_Items.Where(x => x.Id_Guia_de_Remision == g.Id_Guia_de_Remision);
                List<Inventario> inventario = new List<Inventario>();
                foreach(var e in guiaItems){
                    Inventario inv = new Inventario();
                    inv.Id_Producto = e.Id_Producto;
                    inv.Cantidad_Total = -e.Cantidad;
                    inventario.Add(inv);
                }
                _context.AddRange(inventario);
                _context.SaveChanges();
                _context.Guia_de_Remisions.Remove(g);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}