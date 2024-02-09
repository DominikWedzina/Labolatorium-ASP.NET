using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<TravelEntity> Travels { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        public DbSet<GuideEntity> Guides { get; set; }
        public string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "travels.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfiguracja związku TravelEntity z GuideEntity
            modelBuilder.Entity<TravelEntity>()
                .HasOne(t => t.Guide)
                .WithMany(g => g.Travels)
                .HasForeignKey(t => t.GuideId);

            // Konfiguracja dla GuideEntity, aby korzystać z Address
            modelBuilder.Entity<GuideEntity>().OwnsOne(g => g.Address);

            // Inicjalizacja danych dla GuideEntity
            modelBuilder.Entity<GuideEntity>().HasData(
                new GuideEntity
                {
                    Id = 1,
                    Name = "John Doe",
                    Languages = "English, Spanish"
                },
                new GuideEntity
                {
                    Id = 2,
                    Name = "Anna Smith",
                    Languages = "French, English"
                },
                new GuideEntity
                {
                    Id = 3,
                    Name = "Carlos Ruiz",
                    Languages = "Spanish, Portuguese"
                },
                new GuideEntity
                {
                    Id = 4,
                    Name = "Liu Wei",
                    Languages = "Chinese, English"
                }
            );

            // Inicjalizacja danych dla Address przypisanych do GuideEntity
            modelBuilder.Entity<GuideEntity>().OwnsOne(g => g.Address).HasData(
                new { GuideEntityId = 1, City = "Barcelona", Street = "Calle Falsa 123", PostalCode = "08001", Region = "Catalonia" },
                new { GuideEntityId = 2, City = "Paris", Street = "Rue de Paris 45", PostalCode = "75001", Region = "Île-de-France" },
                new { GuideEntityId = 3, City = "Lisbon", Street = "Avenida de Liberdade 170", PostalCode = "1250-146", Region = "Lisboa" },
                new { GuideEntityId = 4, City = "Beijing", Street = "Dongcheng District 5", PostalCode = "100010", Region = "Beijing" }
            );


            modelBuilder.Entity<OrganizationEntity>().OwnsOne(e => e.Address);

            modelBuilder.Entity<TravelEntity>()
                .HasOne(e => e.Organization)
                .WithMany(o => o.Travels)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>().HasData(
                 new OrganizationEntity()
                 {
                     Id = 1,
                     Title = "ITAKA",
                     Nip = "83492384",
                     Regon = "13424234",
                 },
                 new OrganizationEntity()
                 {
                     Id = 2,
                     Title = "TUI",
                     Nip = "2498534",
                     Regon = "0873439249",
                 }
             );

            modelBuilder.Entity<TravelEntity>().HasData(
            new TravelEntity
            {
                Id = 1,
                Name = "To Madrid",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 1, 10),
                StartPlace = "Madrid",
                EndPlace = "Luna",
                Participants = "Juan, Pedro, Luis",
                GuideId = 1,
                OrganizationId = 1
            },
            new TravelEntity
            {
                Id = 2,
                Name = "To Paris",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 1, 10),
                StartPlace = "London",
                EndPlace = "Paris",
                Participants = "Matt, Arthur, Kate",
                GuideId = 2,
                OrganizationId = 2
            }
            );

            modelBuilder.Entity<OrganizationEntity>()
           .OwnsOne(e => e.Address)
           .HasData(
               new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150", Region = "małopolskie" },
               new { OrganizationEntityId = 2, City = "Kraków", Street = "Krowoderska 45/6", PostalCode = "31-150", Region = "małopolskie" }
           );




            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            // dodanie roli administratora
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            // Dodanie roli użytkownika
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = USER_ROLE_ID,
                Name = "user",
                NormalizedName = "USER",
                ConcurrencyStamp = USER_ROLE_ID
            });

            // haszowanie hasła
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();

            // utworzenie administratora jako użytkownika
            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "admin@example.com",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                PasswordHash = ph.HashPassword(null, "1234abcd!"),
            };


            // zapisanie użytkownika
            modelBuilder.Entity<IdentityUser>().HasData(admin);
            // przypisanie roli administratora użytkownikowi
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            // Dodanie drugiego użytkownika
            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = "user@example.com",
                EmailConfirmed = true,
                UserName = "userexample",
                NormalizedUserName = "USEREXAMPLE",
                NormalizedEmail = "USER@EXAMPLE.COM",
                PasswordHash = ph.HashPassword(null, "user1234PASSWORD!@#$")
            };

            modelBuilder.Entity<IdentityUser>().HasData(user);

            // Przypisanie roli USER drugiemu użytkownikowi
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            });


        }
    }

}
