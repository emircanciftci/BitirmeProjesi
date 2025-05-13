using BP.AdminUI.Atributte;
using BP.AdminUI.Models;
using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BP.AdminUI.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult LoginControl(LoginVM gelen)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (service.UserService.logincontrol(gelen.UserName, gelen.Password))
        //        {
        //            User use = service.UserService.FindUserName(gelen.UserName);
        //            SessionContext _sessionContext = new SessionContext()
        //            {
        //                ID = use.ID,
        //                UserName = use.Mail,
        //            };
        //            Session["SessionContext"] = _sessionContext;
        //            return Json(true, JsonRequestBehavior.AllowGet);
        //        }
        //        else
        //        {
        //            return Json(false, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    else
        //    {
        //        return Redirect("/login/Index");
        //    }

        //}
    }
}