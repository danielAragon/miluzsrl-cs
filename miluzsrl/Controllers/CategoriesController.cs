using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miluzsrl.Controllers
{
    public class CategoriesController : Controller
    {
        public object ICategoriaRepository { get; private set; }

        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
            ICategoriaRepository categoriaRepository = 
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }
        public ActionResult Actualizar()
        {
            return View();
        }
    }
}