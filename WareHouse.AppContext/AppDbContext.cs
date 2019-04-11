using Microsoft.EntityFrameworkCore;
using WareHouse.Entities;
using System;
using System.Collections.Generic;

namespace WareHouse.AppContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Stock>().HasData(
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "Stock 1",

                },new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "Stock 2",

                },new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "Stock 3",

                }
                );
        }
    }
}
