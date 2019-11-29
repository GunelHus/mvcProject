using MvcProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class BaseController : Controller
    {
        protected Dbcontext db;
        public BaseController()
        {
            db = new Dbcontext();
            ViewBag.Setting = db.Settings.FirstOrDefault();
        }
      
      
    }
}