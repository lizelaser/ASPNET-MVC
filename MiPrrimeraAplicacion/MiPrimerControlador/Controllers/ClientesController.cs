using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimerControlador.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode(nombre); //Convierte el parámetro que 
            //le pasemos en texto plano
            return Content(input);
        }

        [HttpGet]
        public ActionResult Buscar()
        {
            var input = "Este es un selector Http Get";
            return Content(input);
        }


    }
}