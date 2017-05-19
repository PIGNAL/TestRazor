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
    public class ClientesController : Controller
    {

        GestorClientes gestorClientes = new GestorClientes();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }

        public ActionResult Guardar(ViewModel.Cliente clienteViewModel)
        {           
            if(ModelState.IsValid)
            {
                gestorClientes.Guardar(clienteViewModel.ConvertirAModelo());
            }
            else
            {
                return View("Alta");
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            var clientes= gestorClientes.Listar();
            return View(clientes.ConvertirAViewModel());
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busqueda(string cliente)
        {
            Logger.Log("Pasó por el action Busqueda");
            var clientes= gestorClientes.Buscar(cliente);
            return View(clientes.ConvertirAViewModel());
        }

        public ActionResult EliminarPorId(int id)
        {
            gestorClientes.Eliminar(id);
            return RedirectToAction("Listar");
        }

        public ActionResult EliminarPorApellidoyNombre(string apellido, string nombre)
        {
            gestorClientes.Eliminar(apellido, nombre);
            return RedirectToAction("Listar");
        }
        public ActionResult Detalle(int id)
        {
            var cliente = gestorClientes.BuscarPorId(id);
            var prueba = cliente.ConvertirAString();                   
            return View(cliente.ConvertirAViewModel());
        }

        public ActionResult Modificar(Cliente cliente)
        {
            gestorClientes.Modificar(cliente);
            return RedirectToAction("Listar");
        }

    }
}