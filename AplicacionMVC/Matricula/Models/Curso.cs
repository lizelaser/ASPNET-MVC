namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            Horarios = new HashSet<Horario>();
            MatriculaDetalles = new HashSet<MatriculaDetalle>();
        }

        public int Id { get; set; }

        public int EspecialidadId { get; set; }

        [Required]
        [StringLength(250)]
        public string Denominacion { get; set; }

        public decimal Matricula { get; set; }

        public decimal Mensualidad { get; set; }

        public int Cuotas { get; set; }

        public virtual Especialidad Especialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario> Horarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatriculaDetalle> MatriculaDetalles { get; set; }
    }
}
