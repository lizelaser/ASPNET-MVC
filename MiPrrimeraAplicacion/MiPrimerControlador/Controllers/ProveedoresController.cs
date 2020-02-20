using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimerControlador.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public string TodosLosProveedores()
        {
            return @"<ul>
                    <li>Lizeth</li>
                    <li>Gedy</li>
                    <li>Noah</li>
                    </ul>
                    ";
        }
    }
}