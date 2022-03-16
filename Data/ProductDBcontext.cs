using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AssignmentWCD_BabyFashionShop.Models;

namespace AssignmentWCD_BabyFashionShop.Data
{
    public class ProductDBcontext : DbContext
        {
            public ProductDBcontext() : base("ConnectionString")
            {

            }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Clothes> Clothes { get; set; }
        }
}