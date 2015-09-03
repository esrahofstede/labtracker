namespace Labtracker.Migrations
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Labtracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Labtracker.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var assignments = new List<Assignment>
            {
                new Models.Assignment { Name = "Rekensom 4" },
                new Models.Assignment { Name = "Nederlands werkwoorden 1" },
                new Models.Assignment { Name = "Scheikunde 5" },
                new Models.Assignment { Name = "Wiskunde 6" }
            };

            assignments.ForEach(s => context.Assignments.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var userToInsert = new ApplicationUser { UserName = "test@student.com", PhoneNumber = "0797697898" };
            

            if (!(context.Users.Any(u => u.UserName == "test@student.com")))
            {
                //userManager.Create(userToInsert, "Password@1");
            }
           
            //userManager.Create(userToInsert3, "Password@1");
            //userManager.Create(userToInsert4, "Password@1");
            //userManager.Create(userToInsert5, "Password@1");
            //userManager.Create(userToInsert6, "Password@1");

            var userassignments = new List<UserAssignment>
                {
                    new UserAssignment { Assignment = assignments.Single(s => s.Name == "Rekensom 4"), UserId = userManager.FindByName("test@student.com").Id },
                    //new UserAssignment { Assignment = assignments.Single(s => s.Name == "Rekensom 4"), UserId = userManager.FindByName("test2@student.com").Id },
                    //new UserAssignment { Assignment = assignments.Single(s => s.Name == "Rekensom 4"), UserId = userManager.FindByName("test3@student.com").Id },
                    //new UserAssignment { Assignment = assignments.Single(s => s.Name == "Rekensom 4"), UserId = userManager.FindByName("test4@student.com").Id },
                    //new UserAssignment { Assignment = assignments.Single(s => s.Name == "Rekensom 4"), UserId = userManager.FindByName("test5@student.com").Id }
                };


            //userassignments.ForEach(s => context.UserAssignments.AddOrUpdate(p => p.User, s));
            context.SaveChanges();
                
        }
    }
}
