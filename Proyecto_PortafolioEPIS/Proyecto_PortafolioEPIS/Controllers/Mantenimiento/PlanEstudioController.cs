using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_PortafolioEPIS.Models;

namespace Proyecto_PortafolioEPIS.Controllers.Mantenimiento
{
    public class PlanEstudioController : Controller
    {
        // GET: PlanEstudio
        //Instanciar la clase Plan de Estudio
        private Tbl_PlanEstudio objPlanEstudio = new Tbl_PlanEstudio();

        public ActionResult Index()
        {
            return View(objPlanEstudio.Listar());
        }

        //Accion Visualizar
        public ActionResult Visualizar(int id)
        {
            return View(objPlanEstudio.Obtener(id));
        }

        //Accion Agregar
        public ActionResult Agregar(int id=0)
        {
            return View(id == 0 ? new Tbl_PlanEstudio() //agrega un nuevo objeto
                            : objPlanEstudio.Obtener(id)
                );
        }

        //Accion Guardar
        public ActionResult Guardar(Tbl_PlanEstudio objPlanEstudio)
        {
            if (ModelState.IsValid)
            {
                objPlanEstudio.Guardar();
                return Redirect("~/PlanEstudio");
            }
            else
            {
                return View("~/Views/PlanEstudio/Agregar");
            }
        }

    }
}