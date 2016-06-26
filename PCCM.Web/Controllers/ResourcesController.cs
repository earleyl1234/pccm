using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCCM.Web.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult AnnualReport()
        {
            return View();
        }
        
        public ActionResult ConstitutionAndByLaws()
        {
            return View();
        }

        public ActionResult JobSearch()
        {
            return View();
        }

        public ActionResult Housing()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Legals()
        {
            return View();
        }

        public ActionResult UsefulLinks()
        {
            return View();
        }
    }
}