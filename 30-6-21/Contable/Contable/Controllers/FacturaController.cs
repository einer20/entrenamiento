using Contable.DataAccess.Modelos;
using Contable.Servicios.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contable.Controllers
{
    public class FacturaController : Controller
    {
        ServicioFactura servicio = new ServicioFactura();

        public override void OnActionExecuted(ActionExecutedContext context) {
            servicio.Dispose();
        }

        [HttpGet]
        public IActionResult Index(string rnc, string nfc)
        {
            var facturas = servicio.BusquedaAll(new DataAccess.DTO.ParameterosBusquedaFactura { NFC = nfc, RNC = rnc});
            return View(facturas);
        }

        [HttpPost]
        public ActionResult Anular(int id)
        {
            servicio.AnularFactura(id);

            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Actualizar(Factura factura) {
            servicio.ActualizarFactura(factura);
            return RedirectToAction("index");
        }
    }
}
