using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;


namespace Web.Controllers
{
    public class UsuarioController : Controller
    {

        List<Usuario> lista = new List<Usuario>();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult List()
        {

            Usuario u1 = new Usuario("test", "jhgf", 15, "jhgdsksh@njkbvj", "bhjdjkg");
            Usuario u2 = new Usuario("test", "jhgf", 15, "jhgdsksh@njkbvj", "bhjdjkg");


            lista.Add(u1);
            lista.Add(u2);
            return View(lista);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Usuario model)
        {
            lista.Add(model);
            return View();
        }

    }
}