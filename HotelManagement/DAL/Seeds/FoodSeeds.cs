using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public class FoodSeeds
    {
        public static readonly Food Food1 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45811"),
            Name = "Pizza",
            Price = 12.99m,
            Description = "Delicious cheese pizza with fresh toppings.",
            IsAvailable = true
        };

        public static readonly Food Food2 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45812"),
            Name = "Burger",
            Price = 8.99m,
            Description = "Juicy beef burger with lettuce and tomato.",
            IsAvailable = true
        };

        public static readonly Food Food3 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45813"),
            Name = "Pasta Alfredo",
            Price = 10.99m,
            Description = "Creamy Alfredo pasta with grilled chicken.",
            IsAvailable = true
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(
                Food1, Food2, Food3
            );
        }
    }
}
