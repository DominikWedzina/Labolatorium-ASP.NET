using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ContactEntity> Contacts;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // w aplikacji głównej robić inaczej
            optionsBuilder.UseSqlite(@"data source=d:\contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            var admin = new IdentityUser()
            {
                Email = "admin@wsei.edu.pl",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL",
                UserName = "admin@wsei.edu.pl",
                NormalizedUserName = "ADMIN@WSEI.EDU.PL",
                EmailConfirmed = true,
                Id = ADMIN_ID,
            };

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "abcd");
            modelBuilder.Entity<IdentityUser>().HasData(admin);
            var adminRole = new IdentityRole()
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ADMIN_ROLE_ID,
                ConcurrencyStamp = ADMIN_ROLE_ID
            };

            modelBuilder.Entity<IdentityRole>().HasData(adminRole);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });

            string USER_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();
            var user = new IdentityUser()
            {
                Email = "user@wsei.edu.pl",
                NormalizedEmail = "USER@WSEI.EDU.PL",
                UserName = "user@wsei.edu.pl",
                NormalizedUserName = "USER@WSEI.EDU.PL",
                EmailConfirmed = true,
                Id = ADMIN_ID,
            };

            user.PasswordHash = passwordHasher.HashPassword(user, "abcd");
            modelBuilder.Entity<IdentityUser>().HasData(user);
            var userRole = new IdentityRole()
            {
                Name = "user",
                NormalizedName = "USER",
                Id = USER_ROLE_ID,
                ConcurrencyStamp = USER_ROLE_ID
            };

            modelBuilder.Entity<IdentityRole>().HasData(userRole);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            });

            modelBuilder.Entity<ContactEntity>().HasKey(e => e.Id);
            modelBuilder.Entity<ContactEntity>().HasData(new ContactEntity()
            {
                Id = 1,
                Name = "Test",
                Email = "test@wsei.edu.pl",
                Phone = "823293924",
                Priority = 1,
            }, new ContactEntity()
            {
                Id = 2,
                Name = "Test2",
                Email = "test2@wsei.edu.pl",
                Phone = "723294587",
                Priority = 3,
                Birth = new DateTime(2009, 10, 10)
            });

        }
    }
}
