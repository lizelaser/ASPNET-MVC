using ASPNETModelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETModelos.Controllers
{
    public class ClientesController : Controller
    {

        public static List<Cliente> ListaClientes = new List<Cliente>
        {
                new Cliente
                {
                    Id =1,
                    Nombre = "Lizeth",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 22
                },
                new Cliente
                {
                    Id = 2,
                    Nombre = "Gedy",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 23
                }


        };

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clientes


        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            // Definimos con el lenguaje de consulta Linq
            /*var clientes = from cliente in TodosLosClientes()
                           orderby cliente.Id
                           select cliente;*/
            /*var clientes = from cliente in ListaClientes
                           orderby cliente.Id
                           select cliente;
            ;*/
            var clientes = from cliente in db.Clientes
                           orderby cliente.Id
                           select cliente;
            return View(clientes);
        }

        // GET: Clientes/Details
        //[OutputCache(Duration = int.MaxValue, VaryByParam = "id")]
        //Filtro de cache donde utiliamos varybyparam para que le asigne
        //el valor máximo de cache para aquellos registros que le pasemos
        //por id
        //Que vayamos almacenando durante un tiempo máximo en cache aquellos registros que coincidan con el id que le estemos pasando
        
        //Entonces esto es bueno ya que ya no se va a realiar de nuevo la consulta a la base de datos y por eso es más rápido
        
        //Perfil de cache!
        [OutputCache(CacheProfile ="Cache5minutos")]

        //Las caches son métodos de optimización y mejoramiento de las aplicaciones web
        // El usuario va ver los resultados más rápidos
        // El desarrollador evta que nuestro servidor y base de datos se sobrecarguen
        // por operaciones que habitualmennte son redundantes
        public ActionResult Details(int id)
        {
            var Clientes = db.Clientes.SingleOrDefault(x=>x.Id==id);
            return View(Clientes);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        /*[HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Cliente cliente = new Cliente();
                cliente.Nombre = collection["Nombre"];
                DateTime JDate;
                DateTime.TryParse(collection["FechaAlta"], out JDate);
                cliente.FechaAlta = JDate;
                string edad = collection["Edad"];
                cliente.Edad = Int32.Parse(edad);
                ListaClientes.Add(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            /*ListaClientes.Add(cliente);
            return RedirectToAction("Index");*/
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Clientes/Edit
        public ActionResult Edit(int id)
        {
            
            var clientes = db.Clientes.FirstOrDefault(m=>m.Id==id);
            return View(clientes);
        }

        // POST: Clientes/Edit
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var clientes = db.Clientes.FirstOrDefault(x=>x.Id==id);
                if(TryUpdateModel(clientes))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(clientes);
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]

        public List<Cliente> TodosLosClientes()
        {
            return new List<Cliente>
            {
                new Cliente
                {
                    Id =1,
                    Nombre = "Lizeth",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 22
                },
                new Cliente
                {
                    Id = 2,
                    Nombre = "Gedy",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 23
                }


            };

        }
    }
}
