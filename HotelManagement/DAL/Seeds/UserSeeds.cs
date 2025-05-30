using HotelManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public static class UserSeeds
    {
        static PasswordHasher<ApplicationUser> hasher = new();

        public static readonly ApplicationUser User1 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd291"),
            UserName = "user1",
            NormalizedUserName = "USER1",
            Email = "user1@example.com",
            NormalizedEmail = "USER1@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd291").ToString(),
            PasswordHash = hasher.HashPassword(null, "User1@Password")
        };

        public static readonly ApplicationUser User2 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd292"),
            UserName = "user2",
            NormalizedUserName = "USER2",
            Email = "user2@example.com",
            NormalizedEmail = "USER2@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd292").ToString(),
            PasswordHash = hasher.HashPassword(null, "User2@Password")
        };

        public static readonly ApplicationUser User3 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd293"),
            UserName = "user3",
            NormalizedUserName = "USER3",
            Email = "user3@example.com",
            NormalizedEmail = "USER3@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd293").ToString(),
            PasswordHash = hasher.HashPassword(null, "User3@Password")
        };

        public static readonly ApplicationUser User4 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd294"),
            UserName = "user4",
            NormalizedUserName = "USER4",
            Email = "user4@example.com",
            NormalizedEmail = "USER4@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd294").ToString(),
            PasswordHash = hasher.HashPassword(null, "User4@Password")
        };

        public static readonly ApplicationUser User5 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd295"),
            UserName = "user5",
            NormalizedUserName = "USER5",
            Email = "user5@example.com",
            NormalizedEmail = "USER5@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd295").ToString(),
            PasswordHash = hasher.HashPassword(null, "User5@Password")
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(User1, User2, User3, User4, User5);
        }
    }
}
