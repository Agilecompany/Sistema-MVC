using ProjetoTCM.Business.General;
using ProjetoTCM.Infrastructure.Common;
using ProjetoTCM.Infrastructure.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCM_1.Models;

namespace TCM_1.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult CadastroCliente(ClientModel clientModel)
        {
            var result = new ClientBusiness().Save(clientModel.ConvertToDomain());

            if (result.Reply == EnumReply.Success)
            {
                return RedirectToAction("Cliente");
            }

            return View(result);
          
        }


        public ActionResult Update(ObjectReply<ClientModel> clientModel)
        {
            var result = new ClientBusiness().Save(clientModel.Entity.ConvertToDomain());

            if (result.Reply == EnumReply.Success)
            {
                return RedirectToAction("Cliente");
            }

            return View("EditClient", result);

        }

        public ActionResult Cliente()
        {
            var result = new ClientBusiness().GetAll();

            return View(result);
        }

        public ActionResult FilterBy(string paramFilter)
        {
            var result = new ClientBusiness().GetAll();

            result.Entity = result.Entity.FindAll(x =>
                                                   x.Name.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.CPF.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Email.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Phone.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.CellPhone.Contains(paramFilter));


            return View("Cliente", result);
        }

        public ActionResult Delete(long id)
        {
            var result = new ClientBusiness().Delete(id);

            return View("Cliente");
        }

        public ActionResult Edit(long id)
        {
            var result = new ClientBusiness().GetByID(id);

            return View("EditClient", result);
        }
    }
}