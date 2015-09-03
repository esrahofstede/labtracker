namespace Labtracker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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


            context.Assignments.AddOrUpdate(
                                a => a.Name,
                                new Models.Assignment { Name = "Rekensom 4" },
                                new Models.Assignment { Name = "Nederlands werkwoorden 1" },
                                new Models.Assignment { Name = "Scheikunde 5" },
                                new Models.Assignment { Name = "Wiskunde 6" }
                            );

        }
    }
}
