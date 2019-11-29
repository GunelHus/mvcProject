using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class PagesController : BaseController
    {
        // GET: Pages
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Faqs()
        {
            return View();
        }

        public ActionResult Pricing()
        {
            return View();
        }

       
    }
}