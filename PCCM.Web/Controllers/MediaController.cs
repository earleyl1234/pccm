using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCCM.Web.Controllers
{
    public class MediaController : Controller
    {
        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Vidoes()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }
    }
}