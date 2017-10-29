using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectPortfolio.Controllers
{
    /// <summary>
    /// Class Definition: Contact controller - To Control Contact View Page and Data Flow
    /// </summary>
    public class ContactController : Controller
    {
        /**
         * Method 1 - Index() is main Contact View Controller Function - No other Model Activity on V1.0 for Resume
         */
        public ActionResult Index()
        {
            return View ();
        }
    }
}
