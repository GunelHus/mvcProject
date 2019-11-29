using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject.ViewModel
{
    public class HomeViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<Advice> Advices { get; set; }

    }
}