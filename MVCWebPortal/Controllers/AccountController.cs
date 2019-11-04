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

        //Login 

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UA_PortalLogin portalLogin)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var UserExists = db.User.Single(usr => usr.Email == portalLogin.Email && usr.PasswordHash == portalLogin.PasswordHash);
                if (UserExists != null)
                {
                    Session["UserID"] = UserExists.UserID.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password incorrect");
                }
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