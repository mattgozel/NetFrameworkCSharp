namespace DvdLibraryService.Migrations
{
    using DvdLibraryService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DvdLibraryService.Models.DvdEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DvdLibraryService.Models.DvdEntities context)
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
            context.Dvd.AddOrUpdate(
                d => d.Title,
                new Dvd { Title = "Sideways", ReleaseYear = 2005, Director = "Alexander Payne", Rating = "R", Notes = "We are not drinking any fucking merlot!" },
                new Dvd { Title = "When Harry Met Sally...", ReleaseYear = 1989, Director = "Rob Reiner", Rating = "R", Notes = "I'll have what she's having." }
            );
        }
    }
}
