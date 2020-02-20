using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltroMVC.Controllers
{
    public class HomeController : Controller
    {

        //[Authorize]
        // GET: Home
        public string Index()
        {
            return "Este es mi controlador home";
        }

        //[Authorize(Roles ="Admin")]-->filtros
        //[OutputCache(Duration =10)]-->filtros
        //En este caso estamos guardando en cache la misma hora durante 10s
        //transcurrido ese tiempo nos vuelve a mostrar la hora actual

        [ActionName("Hora")]//--> selector
        public string HoraActual()
        {
            return ObtenerHoraActual();
        }

        [NonAction] //Este método no se va a poder acceder via url
        //se va tener que llamar por HoraActual()
        public string ObtenerHoraActual()
        {
            return "La hora actual es:" + DateTime.Now.ToString("T");
        }


    }
}