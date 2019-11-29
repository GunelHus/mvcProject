using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> Comments { get; set; }
        public string Department{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Quote { get; set; }

    }
}