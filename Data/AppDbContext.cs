using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        //public DbSet<TravelEntity> Travels;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // w aplikacji głównej robić inaczej
            optionsBuilder.UseSqlite(@"data source=d:\contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
