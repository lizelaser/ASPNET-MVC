using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETCodeFirst.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }
        [Column("Apellido")]
        public string Apellidos { get; set; }
        [Required]
        public string Nombre { get; set; }
        public DateTime FechaMatricula { get; set; }
        [NotMapped] // Especificar que no queremos guardar esa info en la BD
        public int NombrePadre { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}