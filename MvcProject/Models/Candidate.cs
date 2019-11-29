using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Fullname { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string Position { get; set; }
        public int Rating { get; set; }
        public string SocialMedia { get; set; }
        public string AboutUs { get; set; }
       
    }
}