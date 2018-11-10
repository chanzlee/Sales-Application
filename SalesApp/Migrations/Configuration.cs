namespace SalesApp.Migrations
{
    using SalesApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesApp.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesApp.Data.SalesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Regions.AddOrUpdate(
                p => p.Id,
                new SalesRegion {
                    Active = true,
                    Code = "NTH",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    Name = "North Region",
                    SalesTarget = 10000.00M,
                    UpdatedBy = "Admin",
                    UpdatedDate = DateTime.Now
                },

                new SalesRegion
                {
                    Active = true,
                    Code = "STH",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 2,
                    Name = "South Region",
                    SalesTarget = 10000.00M,
                    UpdatedBy = "Admin",
                    UpdatedDate = DateTime.Now
                }
            );



            context.People.AddOrUpdate(
                p => p.Id,
                new SalesPerson
                {
                    FirstName = "Chan",
                    LastName = "Lee",
                    RegionId = 1,
                    SalesTarget = 2000.00M,
                    Active = true,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    UpdatedBy = "Admin",
                    UpdatedDate = DateTime.Now
                }
            );

            context.Sales.AddOrUpdate(
                p => p.Id,
                new Sale
                {
                    Amount = 300.00M,
                    Date = DateTime.Now,
                    Id = 1,
                    PersonId = 1,
                    RegionId = 1,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    UpdatedBy = "Admin",
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
}
