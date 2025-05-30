using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public static class RoleSeeds
    {
        public static readonly IdentityRole<Guid> Customer = new IdentityRole<Guid>
        {
            Id = Guid.Parse("87600eb8-1da1-452a-a0bc-0d9c808b4b11"),
            Name = "Customer",
            NormalizedName = "CUSTOMER"
        };

        public static readonly IdentityRole<Guid> Receptionist = new IdentityRole<Guid>
        {
            Id = Guid.Parse("87600eb8-1da1-452a-a0bc-0d9c808b4b12"),
            Name = "Receptionist",
            NormalizedName = "RECEPTIONIST"
        };

        public static readonly IdentityRole<Guid> Manager = new IdentityRole<Guid>
        {
            Id = Guid.Parse("87600eb8-1da1-452a-a0bc-0d9c808b4b13"),
            Name = "Manager",
            NormalizedName = "MANAGER"
        };

        public static readonly IdentityRole<Guid> Staff = new IdentityRole<Guid>
        {
            Id = Guid.Parse("87600eb8-1da1-452a-a0bc-0d9c808b4b14"),
            Name = "Staff",
            NormalizedName = "STAFF"
        };

        public static readonly IdentityRole<Guid> KitchenStaff = new IdentityRole<Guid>
        {
            Id = Guid.Parse("87600eb8-1da1-452a-a0bc-0d9c808b4b15"),
            Name = "KitchenStaff",
            NormalizedName = "KITCHENSTAFF"
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(Customer, Receptionist, Manager, Staff, KitchenStaff);
        }
    }
}
