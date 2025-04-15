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
        public DbSet<ActivityRecord> ActivityRecords { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodOrder> FoodOrders { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>()
                .Property(b => b.Price)
                .HasColumnType("decimal(10, 2)");

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

            modelBuilder.Entity<FoodOrder>()
                .HasMany(f => f.Foods)
                .WithMany(b => b.FoodOrders)
                .UsingEntity<Dictionary<string, object>>(
                    "FoodOrderFoods",
                    f => f.HasOne<Food>().WithMany().HasForeignKey("FoodsId"),
                    b => b.HasOne<FoodOrder>().WithMany().HasForeignKey("FoodOrdersId"),
                    je =>
                    {
                        je.HasKey("FoodsId", "FoodOrdersId");
                        je.ToTable("FoodOrderFoods");
                    });

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Users)
                .WithMany(u => u.Events)
                .UsingEntity<Dictionary<string, object>>(
                    "EventUsers",
                    e => e.HasOne<ApplicationUser>().WithMany().HasForeignKey("UsersId"),
                    u => u.HasOne<Event>().WithMany().HasForeignKey("EventsId"),
                    je =>
                    {
                        je.HasKey("UsersId", "EventsId");
                        je.ToTable("EventUsers");
                    });



            UserSeeds.Seed(modelBuilder);
            RoomSeeds.Seed(modelBuilder);
            BookingSeeds.Seed(modelBuilder);
            FoodSeeds.Seed(modelBuilder);
            FoodOrderSeeds.Seed(modelBuilder);
            ActivityRecordSeeds.Seed(modelBuilder);
            ReviewSeeds.Seed(modelBuilder);
            EventSeeds.Seed(modelBuilder);
            RoleSeeds.Seed(modelBuilder);
            UserRoleSeeds.Seed(modelBuilder);
        }
    }
}
