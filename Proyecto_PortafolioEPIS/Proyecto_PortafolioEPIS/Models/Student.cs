namespace Proyecto_PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int StudentId { get; set; }

        public int? PersonId { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public virtual Person Person { get; set; }
    }
}
