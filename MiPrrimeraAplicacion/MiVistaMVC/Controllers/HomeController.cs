using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiVistaMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string MiControlador()
        {
            return "Mi controlador";
        }

        public ActionResult MiVista()
        {
            return View();
        }
    }
}