using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_PortafolioEPIS.Controllers.Mantenimiento
{
    public class PlanEstudioController : Controller
    {
        // GET: PlanEstudio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
    }
}