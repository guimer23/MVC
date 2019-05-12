namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_DetalleCargaAcademica
    {
        [Key]
        public int Codigo_DetalleCargaAcademica { get; set; }

        public int Codigo_PlanEstudio { get; set; }

        public int Codigo_CargaAcademica { get; set; }

        public int Codigo_Docente { get; set; }

        public int Codigo_Seccion { get; set; }

        public int Codigo_DetallePlanEstudio { get; set; }

        public int Codigo_Semestre { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado_DetalleCargaAcademica { get; set; }

        public virtual Tbl_CargaAcademica Tbl_CargaAcademica { get; set; }

        public virtual Tbl_PlanEstudio Tbl_PlanEstudio { get; set; }

        public virtual Tbl_Docente Tbl_Docente { get; set; }

        public virtual Tbl_Seccion Tbl_Seccion { get; set; }

        public virtual Tbl_DetallePlanEstudio Tbl_DetallePlanEstudio { get; set; }

        public virtual Tbl_Semestre Tbl_Semestre { get; set; }
    }
}
