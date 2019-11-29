using MvcProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel {
                Jobs= db.Jobs.Include("Company").ToList(),
                Advices = db.Advices.ToList()
            };
            return View(model);
        }

     
    }
}