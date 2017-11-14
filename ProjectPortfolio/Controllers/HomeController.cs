using System;
using System.Web.Mvc;

namespace ProjectPortfolio.Controllers
{
    public class HomeController : Controller
    {
        /**
         * Method 1 - Index() is main Home View Controller Function - No other Model Activity on V1.0 for Resume
         */
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }
    }
}
