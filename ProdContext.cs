using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ConsoleApp3
{
    public class ProdContext : DbContext
    {
        public ProdContext() : base("Data Source=ADMIN-KOMPUTER\\BAZALOKALNA;Initial Catalog=ConsoleApp3;Integrated Security=SSPI;")
        {

        }
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            //dbModelBuilder.Entity<Category>().Property(p => p.CatName).HasColumnName("Name");
            dbModelBuilder.Entity<Product>().Property(p => p.UnitPrice).HasColumnType("Decimal");
        } 

        public  DbSet<Product> Products { get; set; }
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
