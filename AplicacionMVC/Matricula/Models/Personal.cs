namespace Matricula.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal")]
    public partial class Personal
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Paterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Materno { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(8)]
        public string Dni { get; set; }

        public int TipoPersonalId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Nacimiento { get; set; }

        [StringLength(500)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        public decimal? Honorario { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaReg { get; set; }

        public DateTime? FechaMod { get; set; }
    }
}
