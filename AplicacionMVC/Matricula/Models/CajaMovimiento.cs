namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CajaMovimiento")]
    public partial class CajaMovimiento
    {
        public int Id { get; set; }

        public int CajaDiarioId { get; set; }

        [Required]
        [StringLength(3)]
        public string Operacion { get; set; }

        public decimal Importe { get; set; }

        public int AlumnoId { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public bool IndEntrada { get; set; }

        public bool Estado { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual CajaDiario CajaDiario { get; set; }
    }
}
