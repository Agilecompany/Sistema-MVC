using MySql.Data.MySqlClient;
using ProjetoTCM.Business.Security;
using ProjetoTCM.Infrastructure.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCM_1.Models;

namespace TCM_1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginEnter(LoginModel loginModel)
        {
            var result = new UserBusiness().Authentication(loginModel.Login, loginModel.Password);

            if (result.Reply == EnumReply.Success)
            {
                Session["UserCredential"] = new UserCredentialModel() { Login = loginModel.Login };

                return View(result);
            }
            return View("Login",result);

        }

        public ActionResult Logoff()
        {
            Session["UserCredential"] = null;

            return View("Login");
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}