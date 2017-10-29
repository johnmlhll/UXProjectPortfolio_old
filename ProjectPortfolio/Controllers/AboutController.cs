using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectPortfolio.Controllers
{
    /// <summary>
    /// Class Definition: About controller - To Control About View Page
    /// </summary>
    public class AboutController : Controller
    {
        /**
         * Method 1 - Index() is main About View Controller Function - No other Model Activity on V1.0 for Resume
         */
        public ActionResult Index()
        {
            return View ();
        }
    }
}
