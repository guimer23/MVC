namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Docente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Docente()
        {
            Tbl_DetalleCargaAcademica = new HashSet<Tbl_DetalleCargaAcademica>();
        }

        [Key]
        public int Codigo_Docente { get; set; }

        public int Codigo_CargoDocente { get; set; }

        public int Codigo_Profesion { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI_Docente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombres_Docente { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos_Docente { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo_Docente { get; set; }

        [Required]
        [StringLength(30)]
        public string EstadoCivil_Docente { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNac_Docente { get; set; }

        [Required]
        [StringLength(200)]
        public string DireccionActual_Docente { get; set; }

        [Required]
        [StringLength(200)]
        public string DireccionReferencia_Docente { get; set; }

        [Required]
        [StringLength(100)]
        public string Correo_Docente { get; set; }

        [Required]
        [StringLength(9)]
        public string TelefonoFijo_Docente { get; set; }

        [Required]
        [StringLength(9)]
        public string TelefonoCelular_Docente { get; set; }

        [Required]
        [StringLength(250)]
        public string Foto_Docente { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado_Docente { get; set; }

        public virtual Tbl_CargoDocente Tbl_CargoDocente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DetalleCargaAcademica> Tbl_DetalleCargaAcademica { get; set; }

        public virtual Tbl_Profesion Tbl_Profesion { get; set; }
    }
}
