using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds

{
    public class RoomSeeds
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca21"),
                    RoomNumber = "101",
                    Description = "Deluxe Room with sea view"
                },
                new Room
                {
                    Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca22"),
                    RoomNumber = "102",
                    Description = "Standard Room with garden view"
                },
                new Room
                {
                    Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca23"),
                    RoomNumber = "103",
                    Description = "Suite with balcony"
                }
            );
        }
    }
}
