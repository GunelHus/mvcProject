using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class Education
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate  { get; set; }
        public string Icon { get; set; }
        public string University { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Field { get; set; }
        public string Description { get; set; }
    }
}