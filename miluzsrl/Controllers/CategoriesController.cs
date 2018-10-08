using miluzsrl.Data_Acces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miluzsrl.Controllers
{
    public class CategoriesController : Controller
    {
        ICategoriaRepository categoriaRepository = new CategoriaRepository()

        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
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