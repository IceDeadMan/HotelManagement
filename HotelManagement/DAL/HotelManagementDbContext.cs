using HotelManagement.DAL.Seeds;
using HotelManagement.Models;
using HotelManagement.Models.JoinEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL
{
    /// <summary>
    /// Represents the database context for the hotel management system.
    /// Includes definion of DbSets, special cases and foreign keys defined in OnModelCreating function,
    /// joint tables, as well as initial data seeds.
    /// Used by Entity Framework to create migrations.
    /// </summary>
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
        public DbSet<EventRegistration> EventRegistrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>()
                .HasMany(r => r.Reviews)
                .WithOne(rev => rev.Room)
                .HasForeignKey(rev => rev.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Room>()
                .HasMany(r => r.ActivityRecords)
                .WithOne(ar => ar.Room)
                .HasForeignKey(ar => ar.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Food>()
                .HasMany(f => f.Reviews)
                .WithOne(rev => rev.Food)
                .HasForeignKey(rev => rev.FoodId)
                .OnDelete(DeleteBehavior.Cascade);

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
                .HasMany(e => e.StaffMembers)
                .WithMany(u => u.AssignedEvents)
                .UsingEntity<Dictionary<string, object>>(
                    "EventStaff",
                    e => e.HasOne<ApplicationUser>().WithMany().HasForeignKey("UserId"),
                    u => u.HasOne<Event>().WithMany().HasForeignKey("EventId"),
                    je =>
                    {
                        je.HasKey("UserId", "EventId");
                        je.ToTable("EventStaff");
                    });

            modelBuilder.Entity<EventRegistration>()
                .HasKey(er => new { er.EventId, er.UserId });

            modelBuilder.Entity<EventRegistration>()
                .HasOne(er => er.Event)
                .WithMany(e => e.Registrations)
                .HasForeignKey(er => er.EventId);

            modelBuilder.Entity<EventRegistration>()
                .HasOne(er => er.User)
                .WithMany(u => u.EventRegistrations)
                .HasForeignKey(er => er.UserId);


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
