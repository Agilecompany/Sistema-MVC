using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCM_1.Controllers
{
    public class FornController : Controller
    {
        public ActionResult Fornecedor()
        {
            return View();
        }

        public ActionResult CadastroForn()
        {
            return View();
        }
    }
}