namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatriculaDetalle")]
    public partial class MatriculaDetalle
    {
        public int Id { get; set; }

        public int MatriculaId { get; set; }

        public int CursoId { get; set; }

        public decimal Nota { get; set; }

        [StringLength(500)]
        public string Observacion { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual Matricula Matricula { get; set; }
    }
}
