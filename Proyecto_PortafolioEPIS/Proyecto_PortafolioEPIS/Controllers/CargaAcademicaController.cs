using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_PortafolioEPIS.Controllers
{
    public class CargaAcademicaController : Controller
    {
        // GET: CargaAcademica
        public ActionResult Index()
        {
            return View();
        }

        //Accion Nuevo
        public ActionResult Nuevo()
        {
            return View();
        }
    }
}