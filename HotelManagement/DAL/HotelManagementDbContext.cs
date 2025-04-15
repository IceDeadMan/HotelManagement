using HotelManagement.DAL.Seeds;
using HotelManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL
{
    public class HotelManagementDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>()
                .HasMany(r => r.Bookings)
                .WithMany(b => b.Rooms)
                .UsingEntity<Dictionary<string, object>>(
                    "RoomBookings",
                    r => r.HasOne<Booking>().WithMany().HasForeignKey("BookingsId"),
                    b => b.HasOne<Room>().WithMany().HasForeignKey("RoomsId"),
                    je =>
                    {
                        je.HasKey("BookingsId", "RoomsId");
                        je.ToTable("RoomBookings");
                    });



            UserSeeds.Seed(modelBuilder);
            RoomSeeds.Seed(modelBuilder);
            BookingSeeds.Seed(modelBuilder);
            RoleSeeds.Seed(modelBuilder);
            UserRoleSeeds.Seed(modelBuilder);
        }
    }
}
