using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCM_1.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult CadastroProdutos()
        {
            return View();
        }

        public ActionResult Produtos()
        {
            return View();
        }
    }
}