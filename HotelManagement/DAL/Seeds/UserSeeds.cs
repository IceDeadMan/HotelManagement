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
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "+421 987 654 321",
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
            FirstName = "Peter",
            LastName = "Novák",
            PhoneNumber = "+421 912 345 678",
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
            FirstName = "Laura",
            LastName = "Kalniņa",
            PhoneNumber = "+371 29876543",
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
            FirstName = "Tomáš",
            LastName = "Kováč",
            PhoneNumber = "+421 903 222 111",
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
            FirstName = "Elīna",
            LastName = "Ozoliņa",
            PhoneNumber = "+371 26443322",
            UserName = "user5",
            NormalizedUserName = "USER5",
            Email = "user5@example.com",
            NormalizedEmail = "USER5@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd295").ToString(),
            PasswordHash = hasher.HashPassword(null, "User5@Password")
        };

        public static readonly ApplicationUser User6 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd296"),
            FirstName = "Marek",
            LastName = "Horváth",
            PhoneNumber = "+421 944 321 987",
            UserName = "user6",
            NormalizedUserName = "USER6",
            Email = "user6@example.com",
            NormalizedEmail = "USER6@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd296").ToString(),
            PasswordHash = hasher.HashPassword(null, "User6@Password")
        };

        public static readonly ApplicationUser User7 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd297"),
            FirstName = "Rihards",
            LastName = "Bērziņš",
            PhoneNumber = "+371 27773311",
            UserName = "user7",
            NormalizedUserName = "USER7",
            Email = "user7@example.com",
            NormalizedEmail = "USER7@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd297").ToString(),
            PasswordHash = hasher.HashPassword(null, "User7@Password")
        };

        public static readonly ApplicationUser User8 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd298"),
            FirstName = "Zuzana",
            LastName = "Šimková",
            PhoneNumber = "+421 905 888 777",
            UserName = "user8",
            NormalizedUserName = "USER8",
            Email = "user8@example.com",
            NormalizedEmail = "USER8@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd298").ToString(),
            PasswordHash = hasher.HashPassword(null, "User8@Password")
        };

        public static readonly ApplicationUser User9 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd299"),
            FirstName = "Jozef",
            LastName = "Mrkva",
            PhoneNumber = "+421 905 888 197",
            UserName = "user9",
            NormalizedUserName = "USER9",
            Email = "user9@example.com",
            NormalizedEmail = "USER9@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd299").ToString(),
            PasswordHash = hasher.HashPassword(null, "User9@Password")
        };

        public static readonly ApplicationUser User10 = new ApplicationUser
        {
            Id = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd29a"),
            FirstName = "Milan",
            LastName = "Bobor",
            PhoneNumber = "+421 905 888 712",
            UserName = "user10",
            NormalizedUserName = "USER10",
            Email = "user10@example.com",
            NormalizedEmail = "USER10@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd29a").ToString(),
            PasswordHash = hasher.HashPassword(null, "User10@Password")
        };


        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(User1, User2, User3, User4, User5, User6, User7, User8, User9, User10);
        }
    }
}
