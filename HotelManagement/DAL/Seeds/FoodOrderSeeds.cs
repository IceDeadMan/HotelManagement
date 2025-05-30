using HotelManagement.Models;
using HotelManagement.Enums;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Models.JoinEntities;

namespace HotelManagement.DAL.Seeds
{
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

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodOrder>().HasData(FoodOrder1, FoodOrder2);

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
                }
            );
        }
    }
}
