using System.Web.Mvc;

namespace ProjectPortfolio.Controllers
{
    /// <summary>
    /// Class Definition: Resume controller - To Control John's Resume View Page
    /// </summary>
    public class ResumeController : Controller
    {
        /**
         * Method 1 - Index() is main Resume View Controller Function - No other Model Activity on V1.0 for Resume
         */
        public ActionResult Index()
        {
            return View ();
        }
    }
}
