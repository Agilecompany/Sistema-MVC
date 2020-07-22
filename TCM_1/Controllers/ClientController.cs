using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCM_1.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult CadastroCliente()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            return View();
        }

        public ActionResult EditCliente()
        {
            return View();
        }
    }
}