using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProject.DAL
{
    public class Dbcontext :DbContext
    {
        public Dbcontext():base("JoobsyConnection")
        {
            
        }
        public DbSet<AboutUs>  AboutUss{ get; set; }
        public DbSet<Advice> Advices { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyReview>  CompanyReviews { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HowItWork> HowItWorks { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SuccessStory> SuccessStories { get; set; }
    }
}