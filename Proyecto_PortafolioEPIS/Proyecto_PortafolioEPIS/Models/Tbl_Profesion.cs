namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Profesion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Profesion()
        {
            Tbl_Docente = new HashSet<Tbl_Docente>();
        }

        [Key]
        public int Codigo_Profesion { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre_Profesion { get; set; }

        [Required]
        [StringLength(10)]
        public string Abrebiatura_Profesion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Docente> Tbl_Docente { get; set; }
    }
}
