using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    /// <summary>
    /// Seeds initial data for room types in the database.
    /// </summary>
    public class RoomTypeSeeds
    {
        public static readonly RoomType RoomType1 = new RoomType
        {
            Id = Guid.Parse("fbf96b7e-04d2-4290-82e7-40a6f1c76b51"),
            Name = "Single",
            Description = "A cozy room for one person",
            Capacity = 1,
            Price = 50.0m
        };

        public static readonly RoomType RoomType2 = new RoomType
        {
            Id = Guid.Parse("fbf96b7e-04d2-4290-82e7-40a6f1c76b52"),
            Name = "Double",
            Description = "Comfortable for two guests",
            Capacity = 2,
            Price = 90.0m
        };

        public static readonly RoomType RoomType3 = new RoomType
        {
            Id = Guid.Parse("fbf96b7e-04d2-4290-82e7-40a6f1c76b53"),
            Name = "Suite",
            Description = "Luxury suite with extra amenities",
            Capacity = 4,
            Price = 160.0m
        };

        public static readonly RoomType RoomType4 = new RoomType
        {
            Id = Guid.Parse("fbf96b7e-04d2-4290-82e7-40a6f1c76b54"),
            Name = "Family",
            Description = "Spacious room for families",
            Capacity = 6,
            Price = 220.0m
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(
                RoomType1, RoomType2, RoomType3, RoomType4
            );
        }
    }
}
