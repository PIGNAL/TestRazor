using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Common;
using TestRazor.ExtensionClasses;
using TestRazor.Models;

namespace TestRazor.Controllers
{
    public class ProductosController : Controller
    {
        GestorProductos gestorProductos = new GestorProductos();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alta()
        {
            return View();
        }

        public ActionResult Guardar(ViewModel.ProductoViewModel productoViewModel)
        {
            if (ModelState.IsValid)
            {
                gestorProductos.Guardar(productoViewModel.ConvertirAModelo());
            }
            else
            {
                return View("Alta");
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            var productos = gestorProductos.Listar();
            return View(productos.ConvertirAViewModel());
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busqueda(string producto)
        {
            Logger.Log("Pasó por el action Busqueda");
            var productos = gestorProductos.BuscarProductos(producto);
            return View(productos.ConvertirAViewModel());
        }

        public ActionResult EliminarPorId(int id)
        {
            gestorProductos.Eliminar(id);
            return RedirectToAction("Listar");
        }

        public ActionResult EliminarPorCodigo(string codigo)
        {
            gestorProductos.Eliminar(codigo);
            return RedirectToAction("Listar");
        }
        public ActionResult Detalle(int id)
        {
            var producto = gestorProductos.Buscar(id);
            var prueba = producto.ConvertirAString();
            return View(producto.ConvertirAViewModel());
        }

        public ActionResult Modificar(Producto producto)
        {
            gestorProductos.Modificar(producto);
            return RedirectToAction("Listar");
        }

    }
}