namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Semestre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Semestre()
        {
            Tbl_CargaAcademica = new HashSet<Tbl_CargaAcademica>();
            Tbl_DetalleCargaAcademica = new HashSet<Tbl_DetalleCargaAcademica>();
            Tbl_PlanEstudio = new HashSet<Tbl_PlanEstudio>();
        }

        [Key]
        public int Codigo_Semestre { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre_Semestre { get; set; }

        public int Anio_Semestre { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado_Semestre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_CargaAcademica> Tbl_CargaAcademica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DetalleCargaAcademica> Tbl_DetalleCargaAcademica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_PlanEstudio> Tbl_PlanEstudio { get; set; }
    }
}
