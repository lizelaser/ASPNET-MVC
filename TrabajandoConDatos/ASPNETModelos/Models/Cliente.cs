using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASPNETModelos.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Display(Name = "Fecha de Alta")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:YYYY/MM/dd}",ApplyFormatInEditMode = true)]
        public DateTime FechaAlta { get; set; }
        [Range(18,90)]
        public int Edad {get;set;}
            
    }
}