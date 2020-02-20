using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiWebAPIMVC.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }

        //En web api los modelos son objetos que representan a los datos de
        //nuestra aplicación
    }
}