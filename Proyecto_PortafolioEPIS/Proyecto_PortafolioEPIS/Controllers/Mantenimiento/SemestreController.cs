using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_PortafolioEPIS.Models;

namespace Proyecto_PortafolioEPIS.Controllers.Mantenimiento
{
    public class SemestreController : Controller
    {
        private Tbl_Semestre objSemestre = new Tbl_Semestre();
        // GET: Semestre
        public ActionResult Index()
        {
            return View(objSemestre.Listar());
        }

        public ActionResult Accion2()
        {
            // Codigo
            return PartialView();
        }
    }
}