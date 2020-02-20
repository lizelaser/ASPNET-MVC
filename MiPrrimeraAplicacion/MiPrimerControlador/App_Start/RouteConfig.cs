using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MiPrimerControlador
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Clientes",
                url: "controller/action/{nombre}",
                defaults: new {controller = "Clientes", action="Buscar", nombre = UrlParameter.Optional}

            );

            routes.MapRoute(
                name: "Proveedores",
                url: "controller/action/{id}",
                defaults: new {controller = "Proveedores", action="TodosLosProveedores", id = UrlParameter.Optional}

            );

        }
    }
}
