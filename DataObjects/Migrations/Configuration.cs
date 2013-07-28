namespace DataObjects.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DataObjects.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<eCommerceEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eCommerceEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Categories.AddOrUpdate(
              c => c.Name,
              new EntityCategory { Name = "Books", Description = "IT related books" },
              new EntityCategory { Name = "Phones", Description = "Only smart phones" },
              new EntityCategory { Name = "Foods", Description = "nutitruos" },
              new EntityCategory { Name = "Vehicles", Description = "4 wheels" }
            );

            context.Products.AddOrUpdate(
              p => p.ProductName,
              new EntityProduct { ProductName = "Learn MVC4", CategoryId = 1, UnitPrice = 12.5, UnitsInStock = 50, Weight = "U" },
              new EntityProduct { ProductName = "AngularJS", CategoryId = 1, UnitPrice = 20.5, UnitsInStock = 100, Weight = "U" },
              new EntityProduct { ProductName = "EntityFramework", CategoryId = 1, UnitPrice = 10.5, UnitsInStock = 75, Weight = "U" },
              new EntityProduct { ProductName = "iPhone 4G", CategoryId = 2, UnitPrice = 485, UnitsInStock = 50, Weight = "U" },
              new EntityProduct { ProductName = "Galaxy S3", CategoryId = 2, UnitPrice = 480, UnitsInStock = 150, Weight = "U" },
              new EntityProduct { ProductName = "Dates", CategoryId = 3, UnitPrice = 1, UnitsInStock = 1050, Weight = "U" },
              new EntityProduct { ProductName = "Kentucky Chicken", CategoryId = 3, UnitPrice = 5.5, UnitsInStock = 400, Weight = "U" },
              new EntityProduct { ProductName = "Noodles", CategoryId = 3, UnitPrice = 2.5, UnitsInStock = 50, Weight = "U" },
              new EntityProduct { ProductName = "Capsa", CategoryId = 3, UnitPrice = 5.5, UnitsInStock = 50, Weight = "U" },
              new EntityProduct { ProductName = "Honda Civic", CategoryId = 4, UnitPrice = 40522.5, UnitsInStock = 50, Weight = "U" },
              new EntityProduct { ProductName = "Lambogini", CategoryId = 4, UnitPrice = 58522.5, UnitsInStock = 50, Weight = "U" }
            );
        }
    }
}
