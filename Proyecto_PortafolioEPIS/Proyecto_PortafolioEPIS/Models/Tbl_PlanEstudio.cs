namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("Tbl_PlanEstudio")]
    public partial class Tbl_PlanEstudio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_PlanEstudio()
        {
            Tbl_DetalleCargaAcademica = new HashSet<Tbl_DetalleCargaAcademica>();
            Tbl_DetallePlanEstudio = new HashSet<Tbl_DetallePlanEstudio>();
        }

        [Key]
        public int Codigo_PlanEstudio { get; set; }

        public int Codigo_Semestre { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre_PlanEstudio { get; set; }

        public DateTime FechaInicio_PlanEstudio { get; set; }

        public DateTime FechaFin_PlanEstudio { get; set; }

        public int TotalCursosObligatorios_PlanEstudio { get; set; }

        public int TotalCursosElectivos_PlanEstudio { get; set; }

        public int TotalCreditosObligatorios_PlanEstudio { get; set; }

        public int TotalCreditosElectivos_PlanEstudio { get; set; }

        public int TotalCreditosExtracurriculares_PlanEstudio { get; set; }

        public int TotalCreditosPracticas_PlanEstudio { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado_PlanEstudio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DetalleCargaAcademica> Tbl_DetalleCargaAcademica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DetallePlanEstudio> Tbl_DetallePlanEstudio { get; set; }

        public virtual Tbl_Semestre Tbl_Semestre { get; set; }


        //Metodo Listar
        public List<Tbl_PlanEstudio> Listar()
        {
            var objPlanEstudio = new List<Tbl_PlanEstudio>();
            try
            {
                using (var db = new Model1())
                {
                    objPlanEstudio = db.Tbl_PlanEstudio.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objPlanEstudio;
        }

        //Metodo Obtener
        public Tbl_PlanEstudio Obtener(int id)//retorna solo un objeto
        {
            var objPlanEstudio = new Tbl_PlanEstudio();
            try
            {
                using (var db = new Model1())
                {
                    objPlanEstudio = db.Tbl_PlanEstudio
                                    .Where(x => x.Codigo_PlanEstudio == id)
                                    .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objPlanEstudio;
        }

        //Metodo Guardar

        public void Guardar()
        {
            try
            {
                using (var db = new Model1())
                {
                    if (this.Codigo_PlanEstudio > 0)//sis existe un valor mayor a cero es porque existe registro
                    {
                        db.Entry(this).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        //SINO EXISTE EL REGISTRO LO GRABA(nuevo)
                        db.Entry(this).State = System.Data.Entity.EntityState.Added;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
