using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public static class UserRoleSeeds
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User1.Id,
                    RoleId = RoleSeeds.Customer.Id
                },
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User2.Id,
                    RoleId = RoleSeeds.Manager.Id
                },
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User3.Id,
                    RoleId = RoleSeeds.Staff.Id
                },
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User4.Id,
                    RoleId = RoleSeeds.Receptionist.Id
                },
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User5.Id,
                    RoleId = RoleSeeds.KitchenStaff.Id
                },
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User6.Id,
                    RoleId = RoleSeeds.Customer.Id
                },
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User7.Id,
                    RoleId = RoleSeeds.Customer.Id
                },
                new IdentityUserRole<Guid>
                {
                    UserId = UserSeeds.User8.Id,
                    RoleId = RoleSeeds.Staff.Id
                }
            );
        }
    }
}
