using ProjetoTCM.Business.General;
using ProjetoTCM.Infrastructure.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCM_1.Models;

namespace TCM_1.Controllers
{
    public class SalesmanController : Controller

    {
        public ActionResult AbrirCadastroFuncionario()
        {
            return View("CadastroFunc");
        }


        public ActionResult CadastroFunc(SalesmanModel salesmanModel)
        {
            var result = new SalesmanBusiness().Save(salesmanModel.ConvertToDomain());

            if (result.Reply == EnumReply.Success)
            {
                return RedirectToAction("Funcionario");
            }

            return View(result);
           
        }

        public ActionResult Funcionario()
        {
            var result = new SalesmanBusiness().GetAll();
            return View();
        }

        public ActionResult FilterBy(string paramFilter)
        {
            var result = new SalesmanBusiness().GetAll();

            result.Entity = result.Entity.FindAll(x =>
                                                   x.Name.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.CPF.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Address.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Phone.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Email.ToUpper().Contains(paramFilter.ToUpper()));
                                               
                                                


            return View("Funcionario", result);
        }

        public ActionResult Delete(long id)
        {
            var result = new SalesmanBusiness().Delete(id);

            return View("Funcionario");
        }

        public ActionResult Edit(long id)
        {
            var result = new SalesmanBusiness().GetByID(id);

            return View("Funcionario", result);
        }
    }
}