using CapaNegocio;
using CapaNegocio.Entities;
using PryPlanEstudios.Tags;
using PryPlanEstudios.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PryPlanEstudios.Controllers
{
    
        [NoLoginAttribute]
        public class LoginController : Controller
        {
            private USUARIO um = new USUARIO();
            // GET: Login
            public ActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Index(LoginViewModel model)
            {
                var rm = new ResponseModel();
                if (ModelState.IsValid)
                {
                    this.um.USU_USUARIO = model.Correo;
                    this.um.USU_CONTRASENIA = model.Password;

                    rm = um.Autenticarse();
                    if (rm.response)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Intento de inicio de sesión no válido.");
                    }
                }
                return View(model);

            }
        }
    }