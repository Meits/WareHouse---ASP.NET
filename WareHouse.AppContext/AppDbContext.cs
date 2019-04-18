using Microsoft.EntityFrameworkCore;
using WareHouse.Entities;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace WareHouse.AppContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


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


            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: "admin",
            salt: salt,

            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));

            builder.Entity<User>().HasData(
               new User
               {
                   Id = Guid.NewGuid(),
                   Firstname = "Admin",
                   Lastname = "Admin",
                   Email = "admin@admin.com",
                   Password = hashed,
                   Salt = Convert.ToBase64String(salt),
                   Token = "7d8das8tdasd8as7d8asygd8as7gd8sa"

               }
          );
        }
    }
}
