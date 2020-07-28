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
    public class ProviderController : Controller
    {

        public ActionResult AbrirCadastroFornecedor()
        {

            return View("CadastroForn");
        }
        public ActionResult CadastroForn( ProviderModel providerModel)
        {

            var result = new ProviderBusiness().Save(providerModel.ConvertToDomain());

            if (result.Reply == EnumReply.Success)
            {
                return RedirectToAction("Fornecedor");
            }

            return View(result);
           
        }

       

        public ActionResult Fornecedor()
        {
            var result = new ProviderBusiness().GetAll();

            return View(result);
        }

        public ActionResult FilterBy(string paramFilter)
        {
            var result = new ProviderBusiness().GetAll();

            result.Entity = result.Entity.FindAll(x =>
                                                   x.Name.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.CNPJ.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Address.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Email.ToUpper().Contains(paramFilter.ToUpper()));


            return View("Fornecedor", result);
        }

        public ActionResult Delete(long id)
        {
            var result = new ProviderBusiness().Delete(id);

            return View("Fornecedor");
        }

        public ActionResult Edit(long id)
        {
            var result = new ProviderBusiness().GetByID(id);

            return View("CadastroForn", result);
        }

    }
}