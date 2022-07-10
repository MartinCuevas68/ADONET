using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class HomeController : Controller
    {
        Datos.PersonaAdmin admin = new Datos.PersonaAdmin();
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Models.PersonaModel> lista = admin.Consultar();
            return View(lista);
        }
    }
}