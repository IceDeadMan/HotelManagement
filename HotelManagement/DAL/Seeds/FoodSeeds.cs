using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    /// <summary>
    /// Seeds initial data for food items in the database.
    /// </summary>
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

        public static readonly Food Food4 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45814"),
            Name = "Caesar Salad",
            Price = 6.99m,
            Description = "Crisp romaine lettuce with Caesar dressing, croutons, and parmesan.",
            IsAvailable = true
        };

        public static readonly Food Food5 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45815"),
            Name = "Sushi Platter",
            Price = 14.99m,
            Description = "Assorted sushi rolls with fresh fish and vegetables.",
            IsAvailable = true
        };

        public static readonly Food Food6 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45816"),
            Name = "Grilled Salmon",
            Price = 13.49m,
            Description = "Fresh salmon fillet grilled to perfection with lemon butter.",
            IsAvailable = true
        };

        public static readonly Food Food7 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45817"),
            Name = "Chicken Tacos",
            Price = 9.49m,
            Description = "Spicy chicken tacos served with salsa and sour cream.",
            IsAvailable = true
        };

        public static readonly Food Food8 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45818"),
            Name = "Vegetable Stir-Fry",
            Price = 8.49m,
            Description = "Mixed vegetables sautéed with soy sauce and garlic.",
            IsAvailable = true
        };

        public static readonly Food Food9 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45819"),
            Name = "BBQ Ribs",
            Price = 15.99m,
            Description = "Tender pork ribs glazed with smoky BBQ sauce.",
            IsAvailable = true
        };

        public static readonly Food Food10 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45820"),
            Name = "Tomato Soup",
            Price = 5.49m,
            Description = "Warm tomato soup served with a slice of toasted bread.",
            IsAvailable = true
        };

        public static readonly Food Food11 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45821"),
            Name = "Fried Rice",
            Price = 7.99m,
            Description = "Classic fried rice with egg, vegetables, and soy sauce.",
            IsAvailable = true
        };

        public static readonly Food Food12 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45822"),
            Name = "Steak",
            Price = 18.99m,
            Description = "Juicy grilled steak served with mashed potatoes.",
            IsAvailable = true
        };

        public static readonly Food Food13 = new Food
        {
            Id = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45823"),
            Name = "Pancakes",
            Price = 6.49m,
            Description = "Fluffy pancakes served with maple syrup and berries.",
            IsAvailable = true
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(
                Food1, Food2, Food3, Food4, Food5, Food6, Food7, Food8, Food9, Food10, Food11, Food12, Food13
            );
        }
    }
}
