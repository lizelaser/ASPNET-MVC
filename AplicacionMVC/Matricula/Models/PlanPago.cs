namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPago")]
    public partial class PlanPago
    {
        public int Id { get; set; }

        public int MatriculaId { get; set; }

        public int Numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaVencimiento { get; set; }

        public decimal Cuota { get; set; }

        public DateTime FechaPago { get; set; }

        public int EstadoId { get; set; }

        public virtual Matricula Matricula { get; set; }
    }
}
