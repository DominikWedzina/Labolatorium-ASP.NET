using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // w aplikacji głównej robić inaczej
            optionsBuilder.UseSqlite(@"data source=d:\contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
