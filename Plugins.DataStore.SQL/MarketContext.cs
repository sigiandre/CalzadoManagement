using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            //seeding some data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Cueros Sinteticos", Description = "Cueros Sinteticos" },
                new Category { CategoryId = 2, Name = "Forros Sinteticos", Description = "Forros Sinteticos" },
                new Category { CategoryId = 3, Name = "Cartones", Description = "Cartones" },
                new Category { CategoryId = 4, Name = "Pegamentos", Description = "Pegamentos" },
                new Category { CategoryId = 5, Name = "Micas", Description = "Micas" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "CAMURGA NEGRO", Quantity = 100, Price = 21.00 },
                new Product { ProductId = 2, CategoryId = 2, Name = "POLIBADANA BEIGE", Quantity = 200, Price = 14.00 },
                new Product { ProductId = 3, CategoryId = 3, Name = "CARTONES LAMINADOS 4.5", Quantity = 162, Price = 25.00 },
                new Product { ProductId = 4, CategoryId = 4, Name = "CALZAPEG", Quantity = 210, Price = 150.00 },
                new Product { ProductId = 5, CategoryId = 5, Name = "MICA TRANSPARENTE", Quantity = 201, Price = 30.00 }
            );
        }
    }
}
