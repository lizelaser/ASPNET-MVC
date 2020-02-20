namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Especialidad")]
    public partial class Especialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Especialidad()
        {
            Cursoes = new HashSet<Curso>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Denominacion { get; set; }

        public decimal Matricula { get; set; }

        public decimal Mensualidad { get; set; }

        public int Cuotas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curso> Cursoes { get; set; }
    }
}
