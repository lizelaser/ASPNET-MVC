namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Horario")]
    public partial class Horario
    {
        public int Id { get; set; }

        public int PeriodoId { get; set; }

        public int CursoId { get; set; }

        public int AulaId { get; set; }

        public int Hora { get; set; }

        public int CantidadHora { get; set; }

        public int Dia { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual Periodo Periodo { get; set; }
    }
}
