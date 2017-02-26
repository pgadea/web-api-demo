using WebAPI2_demo.Models;

namespace WebAPI2_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI2_demo.Models.WebAPI2_demoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPI2_demo.Models.WebAPI2_demoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Contacts.AddOrUpdate(new Contact[] {
              new Contact { Id = 0, FirstName = "Andrew", LastName = "Peters" },
              new Contact { Id = 1, FirstName = "Brice", LastName = "Lambson" },
              new Contact { Id = 2, FirstName = "Rowan", LastName = "Miller" }
            });

        }
    }
}