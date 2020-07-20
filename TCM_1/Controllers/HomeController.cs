using MySql.Data.MySqlClient;
using ProjetoTCM.Business.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCM_1.Controllers
{
    public class HomeController : Controller
    {    

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginEnter(string login, string password)
        {
            var result = new UserBusiness().Authentication(login, password);

            return View(result);
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}