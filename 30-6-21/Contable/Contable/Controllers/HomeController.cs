using Contable.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Contable.Controllers
{
    public class HomeController : Controller
    {

        /*
         * Web = Modulos de la vista(modulo principal)
         * Servicios = Logica de Negocios
         * DataAccess = Modelos y acceso a base de datos(DbContext)
         */

        public IActionResult Index() {

            return View();
        }

        [HttpPost]
        public ActionResult RegistrarPaciente()
        {
   
            return RedirectToAction("index");
        }


    }
}
