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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroCliente()
        {
            return View();
        }

        public ActionResult CadastroFunc()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginEnter(string login, string password)
        {
            var result = new UserBusiness().Authentication(login, password);

            return View(result);
        }

        public ActionResult CadastroProdutos()
        {
            return View();
        }

        public ActionResult Pagamento()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            return View();
        }

        public ActionResult Produtos()
        {
            return View();
        }

        public ActionResult EditCliente()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult Funcionario()
        {
            return View();
        }

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