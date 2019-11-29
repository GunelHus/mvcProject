using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CompanyType { get; set; }
        public string WebSite { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool isVerified { get; set; }

        public List<Employee> Employees { get; set; }
        
        public string ExperienceYears { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
       
        public List<CompanyReview> CompanyReviews { get; set; }
        public string OverView { get; set; }
        public string Service { get; set; }
        public List<string> Details { get; set; }
        public string OpeningHours { get; set; }
    }
}