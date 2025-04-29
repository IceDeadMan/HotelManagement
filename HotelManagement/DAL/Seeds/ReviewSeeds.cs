using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public class ReviewSeeds
    {
        public static readonly Review Review1 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7291"),
            ApplicationUserId = UserSeeds.User1.Id,
            RoomId = RoomSeeds.Room1.Id,
            Rating = 9,
            Comment = "Excellent service and clean room!",
            ReviewDate = DateTime.Now
        };

        public static readonly Review Review2 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7292"),
            ApplicationUserId = UserSeeds.User1.Id,
            FoodId = FoodSeeds.Food1.Id,
            Rating = 7,
            Comment = "Pretty decent pizza",
            ReviewDate = DateTime.Now
        };

        public static readonly Review Review3 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7293"),
            ApplicationUserId = UserSeeds.User1.Id,
            RoomId = RoomSeeds.Room2.Id,
            Rating = 5,
            Comment = "Average experience, could be better.",
            ReviewDate = DateTime.Now
        };

        public static readonly Review Review4 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7294"),
            ApplicationUserId = UserSeeds.User1.Id,
            FoodId = FoodSeeds.Food2.Id,
            Rating = 8,
            Comment = "Great burger, will order again!",
            ReviewDate = DateTime.Now
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(Review1, Review2, Review3, Review4);
        }
    }
}
