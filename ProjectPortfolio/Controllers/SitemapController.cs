using System.Web.Mvc;

namespace ProjectPortfolio.Controllers
{
    public class SitemapController : Controller
    {
        /// <summary>
        /// Class Defintion: Acts as Controller for the sitemap
        /// </summary>
        public ActionResult Index()
        {
            return View ();
        }
    }
}
