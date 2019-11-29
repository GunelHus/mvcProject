namespace MvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Advices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        Department = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Quote = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Fullname = c.String(),
                        CompanyId = c.Int(nullable: false),
                        Position = c.String(),
                        Rating = c.Int(nullable: false),
                        SocialMedia = c.String(),
                        AboutUs = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        CompanyType = c.String(),
                        WebSite = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        isVerified = c.Boolean(nullable: false),
                        ExperienceYears = c.String(),
                        Photo = c.String(),
                        OverView = c.String(),
                        Service = c.String(),
                        OpeningHours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.EmployeeId)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Fullname = c.String(),
                        Position = c.String(),
                        WorkPlace = c.String(),
                        Rating = c.Int(nullable: false),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        Name = c.String(),
                        Text = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                        Jobtype = c.String(),
                        City = c.String(),
                        CountryId = c.Int(nullable: false),
                        Country = c.String(),
                        Gender = c.String(),
                        Shift = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Description = c.String(),
                        IsAcceptedByAdmin = c.Boolean(nullable: false),
                        MinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        Icon = c.String(),
                        University = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Field = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        CompanyId = c.Int(nullable: false),
                        Position = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.HowItWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        FacebookLink = c.String(),
                        InstagramLink = c.String(),
                        TwitterLink = c.String(),
                        GoogleLink = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SuccessStories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Photo = c.String(),
                        Fullname = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Experiences", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Educations", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Jobs", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Candidates", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Employees", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.CompanyReviews", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.CompanyReviews", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Experiences", new[] { "CompanyId" });
            DropIndex("dbo.Educations", new[] { "CandidateId" });
            DropIndex("dbo.Jobs", new[] { "CategoryId" });
            DropIndex("dbo.Jobs", new[] { "CompanyId" });
            DropIndex("dbo.Employees", new[] { "Company_Id" });
            DropIndex("dbo.CompanyReviews", new[] { "Company_Id" });
            DropIndex("dbo.CompanyReviews", new[] { "EmployeeId" });
            DropIndex("dbo.Candidates", new[] { "CompanyId" });
            DropTable("dbo.SuccessStories");
            DropTable("dbo.Settings");
            DropTable("dbo.HowItWorks");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.Clients");
            DropTable("dbo.Jobs");
            DropTable("dbo.Categories");
            DropTable("dbo.Employees");
            DropTable("dbo.CompanyReviews");
            DropTable("dbo.Companies");
            DropTable("dbo.Candidates");
            DropTable("dbo.Blogs");
            DropTable("dbo.Advices");
            DropTable("dbo.AboutUs");
        }
    }
}
