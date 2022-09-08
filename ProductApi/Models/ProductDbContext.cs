using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ProductApi.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public ProductDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
               .Property(x => x.Id)
               .IsRequired();

            modelBuilder.Entity<Product>()
              .Property(x => x.Name)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Product>()
              .Property(x => x.Price)
              .IsRequired()
              .HasMaxLength(100);

            var json = System.IO.File.ReadAllText("Data.json");
            var product = JsonSerializer.Deserialize<List<Product>>(json);
            modelBuilder.Entity<Product>().HasData(product);
        }
        public DbSet<Product> Products { get; set; }
    }
}
