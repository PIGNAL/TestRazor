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
    public class ProveedoresController : Controller
    {
        GestorProveedores gestorProvedor = new GestorProveedores();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alta()
        {
            return View();
        }
        public ActionResult Guardar(ViewModel.ProveedorViewModel proveedorViewModel)
        {
            if (ModelState.IsValid)
            {
                gestorProvedor.Guardar(proveedorViewModel.ConvertirAModelo());
            }
            else
            {
                return View("Alta");
            }
            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
            var proveedores = gestorProvedor.Listar();
            return View(proveedores.ConvertirAViewModel());
        }
        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Busqueda(string proveedor)
        {
            Logger.Log("Pasó por el action Busqueda");
            var proveedores = gestorProvedor.BuscarProveedores(proveedor);
            return View(proveedores.ConvertirAViewModel());
        }
        public ActionResult EliminarPorId(int id)
        {
            gestorProvedor.Eliminar(id);
            return RedirectToAction("Listar");
        }
        public ActionResult EliminarPorNombre(string proveedor)
        {
            gestorProvedor.Eliminar(proveedor);
            return RedirectToAction("Listar");
        }
        public ActionResult Detalle(int id)
        {
            var proveedor = gestorProvedor.Buscar(id);
            return View(proveedor.ConvertirModelAViewModel());
        }
        public ActionResult Modificar(Proveedor proveedor)
        {
            gestorProvedor.Modificar(proveedor);
            return RedirectToAction("Listar");
        }
    }
}