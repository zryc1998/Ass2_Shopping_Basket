namespace Ass2_Shopping_Basket.Migrations.StoreConfiguration
{

    using Models;
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class StoreConfiguration : DbMigrationsConfiguration<Ass2_Shopping_Basket.Models.StoreContext>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ass2_Shopping_Basket.Models.StoreContext context)
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
            //var categories = new List<Category>
            //{
            //    new Category {Name = "Computers and Tablets" },
            //    new Category {Name = "PC Peripherals" },
            //    new Category {Name = "PC Parts" },
            //    new Category {Name = "Networking" },
            //    new Category {Name = "Printing and Office" },
            //    new Category {Name = "Software and Games" },
            //    new Category {Name = "Phones and GPS" },
            //    new Category {Name = "TV Video and Audio" },
            //    new Category {Name = "Cameras and Drones" },
            //    new Category {Name = "Toys and More" },
            //    new Category {Name = "Apple"}
            //};
            //categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            //context.SaveChanges();

            //var brands = new List<Brand>
            //{
            //    new Brand {Name = "Lenovo" },
            //    new Brand {Name = "ASUS" },
            //    new Brand {Name = "Samsung" },
            //    new Brand {Name = "8Ware" },
            //    new Brand {Name = "Brother" },
            //    new Brand {Name = "Microsoft" },
            //    new Brand {Name = "TP Link" },
            //};
            //brands.ForEach(c => context.Brands.AddOrUpdate(p => p.Name, c));
            //context.SaveChanges();

            //var products = new List<Product>
            //{
            //    new Product {Name = "L510", Description = "All in one", Price = 631, CategoryID= categories.Single(c=>c.Name == "Computers and Tablets").ID, BrandID= brands.Single(c=>c.Name == "Lenovo").ID},
            //    new Product {Name = "VE248", Description = "LED Gaming Monitor", Price = 239, CategoryID= categories.Single(c=>c.Name == "PC Peripherals").ID, BrandID= brands.Single(c=>c.Name == "ASUS").ID},
            //    new Product {Name = "S32351", Description = "Full HD LED Monitor", Price = 369, CategoryID= categories.Single(c=>c.Name == "PC Peripherals").ID, BrandID= brands.Single(c=>c.Name == "Samsung").ID},
            //    new Product {Name = "Strix GeForce", Description = "GTX1060 Grpahics Card 6GB", Price = 573, CategoryID= categories.Single(c=>c.Name == "PC Parts").ID, BrandID= brands.Single(c=>c.Name == "ASUS").ID},
            //    new Product {Name = "USB Blutooth Adapter", Description = "V4 Adapter Version", Price = 19.49M, CategoryID= categories.Single(c=>c.Name == "Networking").ID, BrandID= brands.Single(c=>c.Name == "8Ware").ID},
            //    new Product {Name = "TN1070 Toner", Description = "Black 1000 Pages", Price = 60.99M, CategoryID= categories.Single(c=>c.Name == "Printing and Office").ID, BrandID= brands.Single(c=>c.Name == "Brother").ID},
            //    new Product {Name = "Windows Home 10", Description = "64 bit", Price = 171, CategoryID= categories.Single(c=>c.Name == "Software and Games").ID, BrandID= brands.Single(c=>c.Name == "Microsoft").ID},
            //    new Product {Name = "XBox One X", Description = "1 TB", Price = 749, CategoryID= categories.Single(c=>c.Name == "TV Video and Audio").ID, BrandID= brands.Single(c=>c.Name == "Microsoft").ID},
            //    new Product {Name = "NC 450", Description = "HD Pan Tilt Wifi Camera", Price = 163.31M, CategoryID= categories.Single(c=>c.Name == "Cameras and Drones").ID, BrandID= brands.Single(c=>c.Name == "TP Link").ID},
            //};
            //products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            //context.SaveChanges();
        }
    }
}
