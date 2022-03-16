using System.Collections.Generic;
using AssignmentWCD_BabyFashionShop.Models;

namespace AssignmentWCD_BabyFashionShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AssignmentWCD_BabyFashionShop.Data.ProductDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AssignmentWCD_BabyFashionShop.Data.ProductDBcontext context)
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
            var categories = new List<Category>
            {
                new Category {Id = 1, Name = "Áo mua đông"},
                new Category {Id = 2, Name = "Áo mua xuân"},
                new Category {Id = 3, Name = "Áo mua hè"},
                new Category {Id = 4, Name = "Áo mua thu"}
            };
            foreach (var VARIABLE in categories)
            {
                context.Categories.Add(VARIABLE);
            }

            var clothesAdd = new List<Clothes>
            {
                new Clothes
                {
                    Id = 1, Name = "Áo em bé 1", Color = "Xanh", Price = 100000,
                    Thumnail =
                        "https://res.cloudinary.com/quynv300192/image/upload/v1647448266/HTB1swnBNMDqK1RjSZSyq6yxEVXaw.jpg_Q55_z1ijxv.jpg",
                    CategoryId = 1, Status = 1
                },
                new Clothes
                {
                    Id = 2, Name = "Áo em bé 2", Color = "Đỏ", Price = 200000,
                    Thumnail =
                        "https://res.cloudinary.com/quynv300192/image/upload/v1647448266/HTB1swnBNMDqK1RjSZSyq6yxEVXaw.jpg_Q55_z1ijxv.jpg",
                    CategoryId = 2, Status = 1
                },
                new Clothes
                {
                    Id = 3, Name = "Áo em bé 3", Color = "Tím", Price = 100000,
                    Thumnail =
                        "https://res.cloudinary.com/quynv300192/image/upload/v1647448266/HTB1swnBNMDqK1RjSZSyq6yxEVXaw.jpg_Q55_z1ijxv.jpg",
                    CategoryId = 4, Status = 1
                },
                new Clothes
                {
                    Id = 4, Name = "Áo em bé 4", Color = "Cam", Price = 100000,
                    Thumnail =
                        "https://res.cloudinary.com/quynv300192/image/upload/v1647448266/HTB1swnBNMDqK1RjSZSyq6yxEVXaw.jpg_Q55_z1ijxv.jpg",
                    CategoryId = 3, Status = 0
                },
                new Clothes
                {
                    Id = 5, Name = "Áo em bé 5", Color = "Vàng", Price = 100000,
                    Thumnail =
                        "https://res.cloudinary.com/quynv300192/image/upload/v1647448266/HTB1swnBNMDqK1RjSZSyq6yxEVXaw.jpg_Q55_z1ijxv.jpg",
                    CategoryId = 4, Status = -1
                }
            };
            foreach (var VARIABLE in clothesAdd)
            {
                context.Clothes.Add(VARIABLE);
            }

            context.SaveChanges();

        }
    }
}
