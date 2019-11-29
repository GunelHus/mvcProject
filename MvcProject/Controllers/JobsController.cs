using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class JobsController : BaseController
    {
        // GET: Jobs
        public ActionResult Listing()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}