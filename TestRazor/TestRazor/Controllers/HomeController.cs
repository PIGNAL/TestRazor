using System.Web.Mvc;
using TestRazor.Models;
using TestRazor.ViewModel;

namespace TestRazor.Controllers
{
    public class HomeController : Controller
    {

        GestorPersonas gestor = new GestorPersonas();
        // GET: Home
        public ActionResult Index()
        {
            var persona = new ViewModel.Persona { Apellido = "TestLastName", Nombre = "TestFirstName" };
            return View(persona);
        }

        public ActionResult Alta()
        {
            return View();
        }

        //public ActionResult Guardar(ViewModel.Persona persona)
        //{




        //}

    }


}