﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class EmployersController : BaseController
    {
        // GET: Employers
        public ActionResult Employers()
        {
            return View();
        }
    }
}