using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiSeguridadMVC.Controllers
{
    [Authorize(Users ="Lizelaser_03@outlook.com")]
    public class AccesoController : Controller
    {

        // GET: Acceso
        
        public ContentResult Privado()
        {
            return Content("Esta parte de la Web es PRIVADA");
        }
        [AllowAnonymous]
        public ContentResult Publico()
        {
            return Content("Esta parte de la Web es PUBLICA");
        }
    }
}