namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            CajaDiarios = new HashSet<CajaDiario>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreCompleto { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        public bool Activo { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        public bool IndCambio { get; set; }

        public int RolId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CajaDiario> CajaDiarios { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
