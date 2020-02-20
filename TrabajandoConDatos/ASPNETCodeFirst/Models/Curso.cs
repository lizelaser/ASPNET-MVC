using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNETCodeFirst.Models
{
    [Table("Cursos")]
    public class Curso
    {
        public int CursoId { get; set; }
        [ConcurrencyCheck]
        //[MaxLength(24),MinLength(5)]
        [StringLength(24)]
        public string Titulo { get; set; }
        [Index]
        public int Creditos { get; set; }
        [Timestamp, DataType("timestamp")]
        public byte[] TStamp { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }
        [InverseProperty("SiguienteCurso")] //Columna de clave externa que pertenece a la clase matrícula
        public virtual ICollection<Matricula> SiguienteCurso { get; set; }
        [InverseProperty("AnteriorCurso")] //Columna de clase externa que pertenece a la clase matrícula
        public virtual ICollection<Matricula> AnteriorCurso { get; set; }

        //En ete ejemplo inverse property hace referencia a quién se matriculó
        //en el curso actual y quién se matriculó en el curso anterior
        //matrículas del curso actuales y anteriores
    }
}