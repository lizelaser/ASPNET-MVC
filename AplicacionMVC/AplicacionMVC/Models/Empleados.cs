using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacionMVC.Models
{
    public class Empleados
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nombre { get; set; }
        [Required]
        [Range(1, 40)]
        public int Antiguedad { get; set; }
        [Required]
        [Range(18,65)]
        public int Edad { get; set; }
        [Required]
        public string Categoria { get; set; }
    }
}