namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_CargoDocente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_CargoDocente()
        {
            Tbl_Docente = new HashSet<Tbl_Docente>();
        }

        [Key]
        public int Codigo_CargoDocente { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre_CargoDocente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Docente> Tbl_Docente { get; set; }
    }
}
