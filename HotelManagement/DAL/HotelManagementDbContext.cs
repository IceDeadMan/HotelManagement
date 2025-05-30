using HotelManagement.DAL.Seeds;
using HotelManagement.Models;
using HotelManagement.Models.JoinEntities;
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
        public DbSet<Event> Events { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<FoodOrderFood> FoodOrderFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>()
                .Property(b => b.Price)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<RoomType>()
                .Property(rt => rt.Price)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<FoodOrderFood>()
                .HasKey(fof => new { fof.FoodId, fof.FoodOrderId });

            modelBuilder.Entity<FoodOrderFood>()
                .HasOne(fof => fof.Food)
                .WithMany(f => f.FoodOrderFoods)
                .HasForeignKey(fof => fof.FoodId);

            modelBuilder.Entity<FoodOrderFood>()
                .HasOne(fof => fof.FoodOrder)
                .WithMany(fo => fo.FoodOrderFoods)
                .HasForeignKey(fof => fof.FoodOrderId);

            modelBuilder.Entity<FoodOrderFood>()
                .ToTable("FoodOrderFoods");

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
            RoomTypeSeeds.Seed(modelBuilder);
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
