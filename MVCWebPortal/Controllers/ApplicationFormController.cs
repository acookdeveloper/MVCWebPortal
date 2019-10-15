using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebPortal.Controllers
{
    public class ApplicationFormController : Controller
    {
        // GET: ApplicationForm
        public ActionResult Index(string name, int numTimes = 1)
        {
            if (name != "")
            {
                ViewData["Message"] = "Hello " + name;
            }
            if (numTimes >= 1){
                ViewData["NumTimes"] = numTimes;
            }
            if (name == "")
            {
                ViewData["Message"] = "No name has been entered.";
            }
            if (numTimes == 1)
            {
                ViewData["NumTimes"] = 0;
            }

            return View();
        }
    }
}