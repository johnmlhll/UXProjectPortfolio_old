using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectPortfolio.Models;

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
            return View();
        }
        /**
         * Method 2 - SubmitEntry() is the submit function from the view with XML modelled contact entry
         */
        public ActionResult SubmitEntry(ContactModel contact)
        {
            ContactProcessor processEntry = new ContactProcessor();
            if (ModelState.IsValid)
            {
                if (processEntry.PostToXMLDB(contact))
                {
                    return View("SubmitEntry", contact);
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }
    }
}
