using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebPortal.Models;

namespace MVCWebPortal.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(UA_PortalLogin portalLogin)
        {

            Session["UserID"] = "2";
            //using (OurDbContext db = new OurDbContext())
            //{
            //    var UserExists = db.User.Single(usr => usr.Email == portalLogin.Email && usr.PasswordHash == portalLogin.PasswordHash);
            //    if (UserExists != null)
            //    {
            //        Session["UserID"] = UserExists.UserID.ToString();
            //        return RedirectToAction("LoggedIn");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "Email or Password incorrect");
            //    }
            //}
            return RedirectToAction("../Home");
        }

    }

}