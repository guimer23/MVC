namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_DetallePlanEstudio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_DetallePlanEstudio()
        {
            Tbl_DetalleCargaAcademica = new HashSet<Tbl_DetalleCargaAcademica>();
        }

        [Key]
        public int Codigo_DetallePlanEstudio { get; set; }

        public int Codigo_PlanEstudio { get; set; }

        [Required]
        [StringLength(20)]
        public string CodigoCurso_DetallePlanEstudio { get; set; }

        [Required]
        [StringLength(150)]
        public string Asignatura_DetallePlanEstudio { get; set; }

        public int HorasTeoricas_DetallePlanEstudio { get; set; }

        public int HorasPracticas_DetallePlanEstudio { get; set; }

        public int TotalHoras_DetallePlanEstudio { get; set; }

        public int TotalCreditos_DetallePlanEstudio { get; set; }

        [Required]
        [StringLength(150)]
        public string PreRequisito_DetallePlanEstudio { get; set; }

        [Required]
        [StringLength(10)]
        public string Ciclo_DetallePlanEstudio { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoCurso_DetallePlanEstudio { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado_DetallePlanEstudio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DetalleCargaAcademica> Tbl_DetalleCargaAcademica { get; set; }

        public virtual Tbl_PlanEstudio Tbl_PlanEstudio { get; set; }
    }
}
