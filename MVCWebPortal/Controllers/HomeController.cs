﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            switch (Session["UserID"])
            {
                case null:
                    return RedirectToAction("../Login");
                case 2:
                    return View();
                default:
                    return View();
            }

            //return View();
            //return RedirectToAction("../Login");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}