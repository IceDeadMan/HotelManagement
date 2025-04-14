using HotelManagement.DAL.Seeds;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL
{
    public class HotelManagementDbContext : DbContext
    {
        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options)
            : base(options)
        {
        }
        // Define DbSet properties for your entities here
        // Example:
        public DbSet<Room> Rooms { get; set; }
        // public DbSet<Booking> Bookings { get; set; }
        // public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity relationships and constraints here

            RoomSeeds.Seed(modelBuilder);
        }
    }
}
