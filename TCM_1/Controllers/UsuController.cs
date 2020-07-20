using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCM_1.Controllers
{
    public class UsuController : Controller
    {
        public ActionResult CadastroUsu()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            return View();
        }
    }
}