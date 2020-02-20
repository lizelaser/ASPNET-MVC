using MiWebAPIMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiWebAPIMVC.Controllers
{
    public class ProductosController : ApiController
    {
        Productos[] productos = new Productos[]
        {
            new Productos {Id=1,Nombre="Casaca",Categoria="Categoría 1", Precio=25},
            new Productos {Id=2,Nombre="Polo",Categoria="Categoría 2", Precio=30},
            new Productos {Id=3,Nombre="Pantalon",Categoria="Categoría 3", Precio=35},
            new Productos {Id=4,Nombre="Short",Categoria="Categoría 4", Precio=40}
        };

        public IEnumerable<Productos> GetTodosLosProductos()
        {
            return productos;
        }

        public IHttpActionResult GetProductos(int id)
        {
            var producto = productos.FirstOrDefault((x)=>x.Id == id);
            if(producto==null)
            {
                return NotFound();
            }
            return Ok(producto); // Que lo muestre por pantalla
        }

    }
}
