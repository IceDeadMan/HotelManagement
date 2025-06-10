using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    /// <summary>
    /// Seeds initial data for reviews in the database.
    /// </summary>
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

        public static readonly Review Review5 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7295"),
            ApplicationUserId = UserSeeds.User6.Id,
            RoomId = RoomSeeds.Room3.Id,
            Rating = 10,
            Comment = "Absolutely loved the view and comfort!",
            ReviewDate = DateTime.Now
        };

        public static readonly Review Review6 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7296"),
            ApplicationUserId = UserSeeds.User7.Id,
            RoomId = RoomSeeds.Room4.Id,
            Rating = 6,
            Comment = "Room was okay, but a bit noisy.",
            ReviewDate = DateTime.Now
        };

        public static readonly Review Review7 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7297"),
            ApplicationUserId = UserSeeds.User6.Id,
            FoodId = FoodSeeds.Food3.Id,
            Rating = 9,
            Comment = "Loved the creamy Alfredo sauce!",
            ReviewDate = DateTime.Now
        };

        public static readonly Review Review8 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7298"),
            ApplicationUserId = UserSeeds.User7.Id,
            FoodId = FoodSeeds.Food4.Id,
            Rating = 7,
            Comment = "Tasty salad, but could use more dressing.",
            ReviewDate = DateTime.Now
        };

        public static readonly Review Review9 = new Review
        {
            Id = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7299"),
            ApplicationUserId = UserSeeds.User7.Id,
            FoodId = FoodSeeds.Food5.Id,
            Rating = 4,
            Comment = "Fries were soggy and under-seasoned.",
            ReviewDate = DateTime.Now
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(Review1, Review2, Review3, Review4, Review5, Review6, Review7, Review8, Review9);
        }
    }
}
