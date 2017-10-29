using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectPortfolio.Controllers
{
    /// <summary>
    /// Class Definition: Irish Tech News controller - To Control Irish Tech News View Page (John's writing page)
    /// </summary>
    public class IrishTechNewsController : Controller
    {
        /**
         * Method 1 - Index() is main IrishTechNews View Controller Function - No other Model Activity on V1.0 for Resume
         */
        public ActionResult Index()
        {
            return View ();
        }
    }
}
