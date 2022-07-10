using crud.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class PersonaController : Controller
    {
        PersonaAdmin admin = new PersonaAdmin();
        // GET: Persona
        public ActionResult Index()
        {
            IEnumerable<Models.PersonaModel> lista = admin.Consultar();
            return View(lista);
        }
    }
}