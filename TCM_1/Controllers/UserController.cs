using ProjetoTCM.Business.Security;
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
    public class UserController : Controller
    {
        public ActionResult CadastroUsu(UserModel userModel)
        {
            var result = new UserBusiness().Save(userModel.ConvertToDomain());

            if (result.Reply == EnumReply.Success)
            {
                return RedirectToAction("User");
            }

            return View(result);
        }

        public ActionResult Update(ObjectReply<UserModel> userModel)
        {
            var result = new UserBusiness().Save(userModel.Entity.ConvertToDomain());

            if (result.Reply == EnumReply.Success)
            {
                return RedirectToAction("User");
            }

            return View("EditUser", result);

        }

        public ActionResult Usuario()
        {
            return View();
        }

        public ActionResult User()
        {
            var result = new UserBusiness().GetAll();

            return View(result);
        }


        public ActionResult FilterBy(string paramFilter)
        {
            var result = new UserBusiness().GetAll();

            result.Entity = result.Entity.FindAll(x =>
                                                   x.Name.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Login.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Email.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Password.ToUpper().Contains(paramFilter.ToUpper())
                                                || x.Profile.ToString().Contains(paramFilter));


            return View("User", result);
        }

        public ActionResult Delete(long id)
        {
            var result = new UserBusiness().Delete(id);

            return View("User");
        }

        public ActionResult Edit(long id)
        {
            var result = new UserBusiness().GetByID(id);

            return View("EditUser", result);
        }
    }
}