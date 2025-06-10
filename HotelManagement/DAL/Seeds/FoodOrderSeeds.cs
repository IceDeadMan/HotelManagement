using HotelManagement.Models;
using HotelManagement.Enums;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Models.JoinEntities;

namespace HotelManagement.DAL.Seeds
{
    /// <summary>
    /// Seeds initial data for food orders in the database.
    /// Includes join entities for food orders and foods.
    /// </summary>
    public class FoodOrderSeeds
    {
        public static readonly FoodOrder FoodOrder1 = new FoodOrder
        {
            Id = Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
            Description = "Order 1",
            OrderDate = DateTime.Now,
            Status = OrderStatus.Pending,
            ApplicationUserId = UserSeeds.User1.Id,
            RoomId = RoomSeeds.Room1.Id
        };

        public static readonly FoodOrder FoodOrder2 = new FoodOrder
        {
            Id = Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
            Description = "Order 2",
            OrderDate = DateTime.Now,
            Status = OrderStatus.Completed,
            ApplicationUserId = UserSeeds.User1.Id,
            RoomId = RoomSeeds.Room2.Id
        };

        public static readonly FoodOrder FoodOrder3 = new FoodOrder
        {
            Id = Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
            Description = "Late night snacks",
            OrderDate = DateTime.Now.AddHours(-2),
            Status = OrderStatus.Pending,
            ApplicationUserId = UserSeeds.User6.Id,
            RoomId = RoomSeeds.Room3.Id
        };

        public static readonly FoodOrder FoodOrder4 = new FoodOrder
        {
            Id = Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
            Description = "Lunch order",
            OrderDate = DateTime.Now.AddDays(-1),
            Status = OrderStatus.Completed,
            ApplicationUserId = UserSeeds.User7.Id,
            RoomId = RoomSeeds.Room4.Id
        };

        public static readonly FoodOrder FoodOrder5 = new FoodOrder
        {
            Id = Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
            Description = "Dinner special",
            OrderDate = DateTime.Now,
            Status = OrderStatus.Pending,
            ApplicationUserId = UserSeeds.User1.Id,
            RoomId = RoomSeeds.Room5.Id
        };

        public static readonly FoodOrder FoodOrder6 = new FoodOrder
        {
            Id = Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2966"),
            Description = "Dinner",
            OrderDate = DateTime.Now.AddDays(-3),
            Status = OrderStatus.Completed,
            ApplicationUserId = UserSeeds.User7.Id,
            RoomId = RoomSeeds.Room13.Id
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodOrder>().HasData(FoodOrder1, FoodOrder2, FoodOrder3, FoodOrder4, FoodOrder5, FoodOrder6);

            // Seed the join table between food orders and foods
            modelBuilder.Entity<FoodOrderFood>().HasData(
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder1.Id,
                    FoodId = FoodSeeds.Food1.Id,
                    Quantity = 2
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder1.Id,
                    FoodId = FoodSeeds.Food2.Id,
                    Quantity = 1
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder2.Id,
                    FoodId = FoodSeeds.Food3.Id,
                    Quantity = 3
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder3.Id,
                    FoodId = FoodSeeds.Food4.Id,
                    Quantity = 1
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder3.Id,
                    FoodId = FoodSeeds.Food5.Id,
                    Quantity = 2
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder4.Id,
                    FoodId = FoodSeeds.Food6.Id,
                    Quantity = 1
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder5.Id,
                    FoodId = FoodSeeds.Food2.Id,
                    Quantity = 1
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder5.Id,
                    FoodId = FoodSeeds.Food9.Id,
                    Quantity = 2
                },
                new FoodOrderFood
                {
                    FoodOrderId = FoodOrder6.Id,
                    FoodId = FoodSeeds.Food13.Id,
                    Quantity = 1
                }
            );
        }
    }
}
