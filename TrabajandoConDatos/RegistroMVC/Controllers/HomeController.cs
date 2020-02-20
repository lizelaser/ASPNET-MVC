using RegistroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //POST: Home
        [HttpPost]
        public ActionResult Index(Registro registro)
        {
            if(ModelState.IsValid)
            {
                AplicationDbContext db = new AplicationDbContext();
                db.Registro.Add(registro);
                db.SaveChanges();
                
            }
            return View(registro);

        }
    }
}