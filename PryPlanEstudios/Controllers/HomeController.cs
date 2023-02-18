using CapaDatos;
using PryPlanEstudios.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PryPlanEstudios.Controllers
{
    [AutenticadoAttribute]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Salir()
        {
            SessionHelper.DestroyUserSession();
            return RedirectToAction("Index", "Login");
        }
    }
}