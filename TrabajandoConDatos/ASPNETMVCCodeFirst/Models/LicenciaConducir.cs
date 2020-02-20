using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETMVCCodeFirst.Models
{
    public class LicenciaConducir
    {
        [Key, Column(Order=1)]
        public int NumeroLicencia { get; set; }
        [Key, Column(Order =2)]
        public string Pais { get; set; }
        public DateTime Expedido { get; set; }
        public DateTime Caduca { get; set; }
    }
}