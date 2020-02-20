namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Matricula")]
    public partial class Matricula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matricula()
        {
            MatriculaDetalles = new HashSet<MatriculaDetalle>();
            PlanPagoes = new HashSet<PlanPago>();
        }

        public int Id { get; set; }

        public int TipoEstudioId { get; set; }

        public int AlumnoId { get; set; }

        public DateTime Fecha { get; set; }

        public int PeridoId { get; set; }

        public decimal Monto { get; set; }

        public bool IndPagoMatricula { get; set; }

        [StringLength(500)]
        public string Observacion { get; set; }

        public int EstadoId { get; set; }

        public virtual Alumno Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatriculaDetalle> MatriculaDetalles { get; set; }

        public virtual Periodo Periodo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanPago> PlanPagoes { get; set; }
    }
}
