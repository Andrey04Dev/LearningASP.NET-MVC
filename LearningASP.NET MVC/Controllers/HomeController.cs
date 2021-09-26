using LearningASP.NET_MVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        private PeliculaRepository _peliculasRepository;

        public HomeController()
        {
            _peliculasRepository = new PeliculaRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            ViewBag.Message = "Exitoso";
            return View(persona);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = _peliculasRepository.ObtenerPeliculas();
            return View(model);
        }

        public ActionResult MiAction(int edad)
        {
            ViewBag.Message = "Your contact page." + edad;
            return View();
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }
    }
}