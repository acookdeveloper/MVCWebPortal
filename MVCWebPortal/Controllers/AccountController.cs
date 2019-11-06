using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebPortal.Models;

namespace MVCWebPortal.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        // Registration

        [HttpPost]
        public ActionResult Register(UA_PortalLogin portalLogin)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.User.Add(portalLogin);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = portalLogin.Email + " successfully registered.";

            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}