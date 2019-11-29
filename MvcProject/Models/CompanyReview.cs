using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class CompanyReview
    {
        public int Id { get; set; }
        public int  EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}