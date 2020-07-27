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
    public class ProductController : Controller
    {
        public ActionResult AbrirCadastroProdutos()
        {
            return View("CadastroProdutos");
        }

        public ActionResult CadastroProdutos(ProductModel productModel)
        {
            var result = new ProductBusiness().Save(productModel.ConvertToDomain());

            if(result.Reply == EnumReply.Success)
            {
                return RedirectToAction("Produtos");
            }

            return View(result);
        }


        public ActionResult Produtos()
        {
              var result = new ProductBusiness().GetAll();

            return View(result);
        }


        public ActionResult FilterBy(string paramFilter)
        {
            var result = new ProductBusiness().GetAll();

            result.Entity = result.Entity.FindAll(x => 
                                                   x.Name.ToUpper().Contains(paramFilter.ToUpper()) 
                                                || x.Description.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.ExternalCode.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Brand.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.ExternalCodeName.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Model.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.UnitPrice.ToString("N2").Contains(paramFilter));


            return View("Produtos",result);
        }

        public ActionResult Delete(long id)
        {
            var result = new ProductBusiness().Delete(id);

            return View("Produtos");
        }

        public ActionResult Edit(long id)
        {
            var result = new ProductBusiness().GetByID(id);

            return View("CadastroProdutos", result);
        }
    }
}