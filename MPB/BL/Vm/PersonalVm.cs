﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PersonalVm
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string TipoPersonal { get; set; }
        public bool Estado { get; set; }
    }
}