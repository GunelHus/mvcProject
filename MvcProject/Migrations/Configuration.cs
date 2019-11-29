namespace MvcProject.Migrations
{
    using MvcProject.DAL;
    using MvcProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcProject.DAL.Dbcontext>
    {
        private readonly Dbcontext db;
        public Configuration()
        {
            db = new Dbcontext();
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcProject.DAL.Dbcontext context)
        {
            db.Settings.AddOrUpdate(s => s.Email, new Models.Setting
            {
                Email = "Support@mail.com",
                Address = "2453 Clinton StreetLittle Rock, AR 72211",
                FacebookLink = "facebook.com",
                GoogleLink = "google.az",
                InstagramLink = "instagram.com",
                Logo = "images/logo-dark.png",
                Phone = "+1 800 123 45 67",
                TwitterLink = "twitter.com"



            });
            db.AboutUss.AddOrUpdate(a => a.Title, new Models.AboutUs[]
            {
                new AboutUs{
                     Title = "Vestibulum ante primis faucibus ?",
                Description = "Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit." +

"Maecenas tempus tellus eget as that condimentum rhoncus sem quam semper libero amete adipiscing sem neque sed ipsum Nam quam nunce blandit at luctus pulvinar hendrerit id lorem Maecenas nec et ante tincidunt tempus." +

"Sed consequat leo eget bibendum sodales augue at velit cursus nunc."
                },

                new AboutUs{
                     Title = "Vestibulum ante primis ucibus ?",
                Description = "Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit." +

"Maecenas tempus tellus eget as that condimentum rhoncus sem quam semper libero amete adipiscing sem neque sed ipsum Nam quam nunce blandit at luctus pulvinar hendrerit id lorem Maecenas nec et ante tincidunt tempus." +

"Sed consequat leo eget bibendum sodales augue at velit cursus nunc."
                },

                new AboutUs{
                     Title = "Vestibulum ante  faucibus ?",
                Description = "Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit." +

"Maecenas tempus tellus eget as that condimentum rhoncus sem quam semper libero amete adipiscing sem neque sed ipsum Nam quam nunce blandit at luctus pulvinar hendrerit id lorem Maecenas nec et ante tincidunt tempus." +

"Sed consequat leo eget bibendum sodales augue at velit cursus nunc."
                },

            });

            db.Advices.AddOrUpdate(d => d.Title, new Models.Advice[]
        {
            new Advice{
            Photo = "images/blog/img-1.jpg",
            Title = "Aenean vulputate eleifend tellus",
            Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam",
            CreatedAt = DateTime.Now
            },
             new Advice{
                Photo = "images/blog/img-2.jpg",
                Title = "Maecenas tempus tellus eget",
                Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam",
                CreatedAt = DateTime.Now
            },
             new Advice{
                Photo = "images/blog/img-3.jpg",
                Title = "Vestibulum ante ipsum primis",
                Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam",
                CreatedAt = DateTime.Now
            }
        });

            db.Companies.AddOrUpdate(c => c.Email, new Models.Company[]
            {
             new Company
             {
                 Name = "Themes code Pvt.Ltd",
                 Address = "4102 Aviation Way Los Angeles, CA 90017",
                 CompanyType = "Create Website",
                 WebSite = "Themescodeltd.co.in",
                 Phone = "123 456 7890",
                 Email = "Themescodeltd2018@gmail.com",
                 isVerified = true,
                 ExperienceYears = "4 Years + Exp.",
                 Photo = "featured-job/img-3.png",
                 OverView ="At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.",
                 Service = "Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.",
                 OpeningHours = "9:00 - 18:00"
             }
            });

            db.Categories.AddOrUpdate(c => c.Name, new Models.Category[]
            {
                new Category
                {
                    Name ="Software Developer"
                },
                 new Category
                {
                    Name ="Accounting"
                },
                  new Category
                {
                    Name ="Marketing Job"
                },
                   new Category
                {
                    Name ="Graphic Dsigner"
                },
                      new Category
                {
                    Name ="Web Developer"
                },
                   new Category
                {
                    Name ="Web Designer"
                },
                   new Category
                {
                    Name ="Digital Marketing"
                },
                   new Category
                {
                    Name ="Education & Training"
                },
                      new Category
                {
                    Name ="Engineering Jobs"
                },
                   new Category
                {
                    Name ="Government Jobs"
                }
            });

            db.Jobs.AddOrUpdate(j => j.Email, new Models.Job[] {
                new Job
                {
                    Name = "Web Developer",
                    Text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praelsentium voluptatum at deleniti atque corrupti quos dolores quas molestias excepturi occaecati cupiditate non provident, similique sunt culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga Temporibus autem quibusdam aut Ut at as enim ad minima veniam quis nostrum that exercitationem ullam corporis suscipit laboriosam officiis debitis aut rerum necessitatibus. Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Email = "Webthemescom@gmail.com",
                    Website = "/www.WebThemes.com",
                    Jobtype = "",
                    City = "New York",
                    Country = "",
                    Gender = "all",
                    Shift = "full time, part time",
                    CreatedAt = DateTime.Now,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    IsAcceptedByAdmin = true,
                    MinSalary = 700,
                    MaxSalary = 800,
                    CategoryId=1,
                    CompanyId=1,
                    CountryId=1


                },
                  new Job
                {
                    Name = "Web Developer",
                    Text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praelsentium voluptatum at deleniti atque corrupti quos dolores quas molestias excepturi occaecati cupiditate non provident, similique sunt culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga Temporibus autem quibusdam aut Ut at as enim ad minima veniam quis nostrum that exercitationem ullam corporis suscipit laboriosam officiis debitis aut rerum necessitatibus. Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Email = "Wethemescom@gmail.com",
                    Website = "www.WebThes.com",
                    Jobtype = "",
                    City = "New York",
                    Country = "",
                    Gender = "all",
                    Shift = "full time, part time",
                    CreatedAt = DateTime.Now,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    IsAcceptedByAdmin = true,
                    MinSalary = 700,
                    MaxSalary = 800,
                    CategoryId=1,
                    CompanyId=1,
                    CountryId=1
                },
                    new Job
                {
                    Name = "Web Developer",
                    Text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praelsentium voluptatum at deleniti atque corrupti quos dolores quas molestias excepturi occaecati cupiditate non provident, similique sunt culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga Temporibus autem quibusdam aut Ut at as enim ad minima veniam quis nostrum that exercitationem ullam corporis suscipit laboriosam officiis debitis aut rerum necessitatibus. Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Email = "Webthemesom@gmail.com",
                    Website = "www.Webhemes.com",
                    Jobtype = "",
                    City = "New York",
                    Country = "",
                    Gender = "all",
                    Shift = "full time, part time",
                    CreatedAt = DateTime.Now,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    IsAcceptedByAdmin = true,
                    MinSalary = 700,
                    MaxSalary = 800,

                    CategoryId=1,
                    CompanyId=1,
                    CountryId=1
                },
                      new Job
                {
                    Name = "Web Developer",
                    Text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praelsentium voluptatum at deleniti atque corrupti quos dolores quas molestias excepturi occaecati cupiditate non provident, similique sunt culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga Temporibus autem quibusdam aut Ut at as enim ad minima veniam quis nostrum that exercitationem ullam corporis suscipit laboriosam officiis debitis aut rerum necessitatibus. Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Email = "Webthescom@gmail.com",
                    Website = "www.WebTh.com",
                    Jobtype = "",
                    City = "New York",
                    Country = "",
                    Gender = "all",
                    Shift = "full time, part time",
                    CreatedAt = DateTime.Now,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    IsAcceptedByAdmin = true,
                    MinSalary = 700,
                    MaxSalary = 800,
                    CategoryId=1,
                    CompanyId=1,
                    CountryId=1

                },
                        new Job
                {
                    Name = "Web Developer",
                    Text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praelsentium voluptatum at deleniti atque corrupti quos dolores quas molestias excepturi occaecati cupiditate non provident, similique sunt culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga Temporibus autem quibusdam aut Ut at as enim ad minima veniam quis nostrum that exercitationem ullam corporis suscipit laboriosam officiis debitis aut rerum necessitatibus. Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Email = "om@gmail.com",
                    Website = "Themescode@gmail.com",
                    Jobtype = "",
                    City = "New York",
                    Country = "",
                    Gender = "all",
                    Shift = "full time, part time",
                    CreatedAt = DateTime.Now,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    IsAcceptedByAdmin = true,
                    MinSalary = 700,
                    MaxSalary = 800,
                    CategoryId=1,
                    CompanyId=1,
                    CountryId=1

                },

            });
            db.SaveChanges();
        }
    }
}
