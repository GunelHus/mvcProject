using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string Name{ get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Jobtype  { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Shift { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CategoryId { get; set; }
        public Category Category  { get; set; }
        public List<string> Quafilications { get; set; }
        public List<string> Responsibilities { get; set; }
        public string Description { get; set; }
        public bool IsAcceptedByAdmin { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
    }

    
}