using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETCodeFirst.Models
{
    [Table("Matriculas")]
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int CursoId { get; set; }
        public int AlumnoId { get; set; }
        public int Precio { get; set; }
        public virtual Curso SiguienteCurso { get; set; }

        public virtual Curso AnteriorCurso { get; set; }
        [ForeignKey("CursoId")]//opcional
        public virtual Curso Curso { get; set; }
        [ForeignKey("AlumnoId")]//obligatorio si la llave primaria no coinde con el nombre de la columna que hara de llave foranea
        public virtual Alumno Alumno { get; set; }

        //SiguienteCurso y AnteriorCurso son propiedades de clave externa
        //columns de clave externa para clase matrícula
    }
}