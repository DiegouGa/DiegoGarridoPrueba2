using Prueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Prueba2.Controllers
{
    public class EstadisticasController : Controller
    {
        private fabricaEntities3 db = new fabricaEntities3();
 public ActionResult Index()
        {
            var promedio = db.Producto.GroupBy(n => n.IdCategoria)
                         .Select(n => new
                         {
                             NCat = n.Key,

                             Cantidad = n.Count(),

                             Porcentaje = ((double)n.Count() * 100/ db.Producto.Count()),

                             promedioPrecio = n.Average(g => g.precio)

                         })
                         .OrderBy(n => n.NCat);
            ViewBag.Datos = promedio;

            return View();
        }



    }
}