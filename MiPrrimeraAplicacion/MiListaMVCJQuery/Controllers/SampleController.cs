using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiListaMVCJQuery.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            List<string> Lista = new List<string>();
            Lista.Add("Seleccionar");
            Lista.Add("España");
            Lista.Add("Mexico");
            Lista.Add("Argentina");

            SelectList Paises = new SelectList(Lista);
            ViewData["Paises"] = Paises;
            return View();
        }

        public JsonResult Provincias(string Pais)
        {
            List<string> ListProv = new List<string>();
            switch (Pais)
            {
                case "España":
                    ListProv.Add("Madrid");
                    ListProv.Add("Galicia");
                    break;
                case "Mexico":
                    ListProv.Add("Mexico D.F.");
                    ListProv.Add("Yucatan");
                    break;
                case "Argentina":
                    ListProv.Add("Buenos Aires");
                    ListProv.Add("Rosario");
                    break;
            }
            return Json(ListProv);
        }

    }
}