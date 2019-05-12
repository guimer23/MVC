namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_CargaAcademica> Tbl_CargaAcademica { get; set; }
        public virtual DbSet<Tbl_CargoDocente> Tbl_CargoDocente { get; set; }
        public virtual DbSet<Tbl_DetalleCargaAcademica> Tbl_DetalleCargaAcademica { get; set; }
        public virtual DbSet<Tbl_DetallePlanEstudio> Tbl_DetallePlanEstudio { get; set; }
        public virtual DbSet<Tbl_Docente> Tbl_Docente { get; set; }
        public virtual DbSet<Tbl_PlanEstudio> Tbl_PlanEstudio { get; set; }
        public virtual DbSet<Tbl_Profesion> Tbl_Profesion { get; set; }
        public virtual DbSet<Tbl_Seccion> Tbl_Seccion { get; set; }
        public virtual DbSet<Tbl_Semestre> Tbl_Semestre { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_CargaAcademica>()
                .Property(e => e.Estado_CargaAcademica)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CargaAcademica>()
                .HasMany(e => e.Tbl_DetalleCargaAcademica)
                .WithRequired(e => e.Tbl_CargaAcademica)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_CargoDocente>()
                .Property(e => e.Nombre_CargoDocente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_CargoDocente>()
                .HasMany(e => e.Tbl_Docente)
                .WithRequired(e => e.Tbl_CargoDocente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_DetalleCargaAcademica>()
                .Property(e => e.Estado_DetalleCargaAcademica)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DetallePlanEstudio>()
                .Property(e => e.CodigoCurso_DetallePlanEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DetallePlanEstudio>()
                .Property(e => e.Asignatura_DetallePlanEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DetallePlanEstudio>()
                .Property(e => e.PreRequisito_DetallePlanEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DetallePlanEstudio>()
                .Property(e => e.Ciclo_DetallePlanEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DetallePlanEstudio>()
                .Property(e => e.TipoCurso_DetallePlanEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DetallePlanEstudio>()
                .Property(e => e.Estado_DetallePlanEstudio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DetallePlanEstudio>()
                .HasMany(e => e.Tbl_DetalleCargaAcademica)
                .WithRequired(e => e.Tbl_DetallePlanEstudio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.DNI_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.Nombres_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.Apellidos_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.Sexo_Docente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.EstadoCivil_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.DireccionActual_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.DireccionReferencia_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.Correo_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.TelefonoFijo_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.TelefonoCelular_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.Foto_Docente)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .Property(e => e.Estado_Docente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Docente>()
                .HasMany(e => e.Tbl_DetalleCargaAcademica)
                .WithRequired(e => e.Tbl_Docente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_PlanEstudio>()
                .Property(e => e.Nombre_PlanEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PlanEstudio>()
                .Property(e => e.Estado_PlanEstudio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PlanEstudio>()
                .HasMany(e => e.Tbl_DetalleCargaAcademica)
                .WithRequired(e => e.Tbl_PlanEstudio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_PlanEstudio>()
                .HasMany(e => e.Tbl_DetallePlanEstudio)
                .WithRequired(e => e.Tbl_PlanEstudio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_Profesion>()
                .Property(e => e.Nombre_Profesion)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Profesion>()
                .Property(e => e.Abrebiatura_Profesion)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Profesion>()
                .HasMany(e => e.Tbl_Docente)
                .WithRequired(e => e.Tbl_Profesion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_Seccion>()
                .Property(e => e.Nombre_Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Seccion>()
                .Property(e => e.Estado_Seccion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Seccion>()
                .HasMany(e => e.Tbl_DetalleCargaAcademica)
                .WithRequired(e => e.Tbl_Seccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_Semestre>()
                .Property(e => e.Nombre_Semestre)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Semestre>()
                .Property(e => e.Estado_Semestre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Semestre>()
                .HasMany(e => e.Tbl_CargaAcademica)
                .WithRequired(e => e.Tbl_Semestre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_Semestre>()
                .HasMany(e => e.Tbl_DetalleCargaAcademica)
                .WithRequired(e => e.Tbl_Semestre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_Semestre>()
                .HasMany(e => e.Tbl_PlanEstudio)
                .WithRequired(e => e.Tbl_Semestre)
                .WillCascadeOnDelete(false);
        }
    }
}
