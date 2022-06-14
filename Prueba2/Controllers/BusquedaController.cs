using Prueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Prueba2.Controllers
{
    public class BusquedaController : Controller
    {
        private fabricaEntities3 db = new fabricaEntities3();
        public ActionResult Index()
        {
            return View(db.Categoria.ToList());
        } public ActionResult buscarcategoria(int id)
        {var queryProducto = from producto in db.Producto where producto.IdCategoria == id select producto;


return View(queryProducto);
        }

    }
}