using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds

{
    public class RoomSeeds
    {
        public static readonly Room Room1 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca21"),
            RoomNumber = "101",
            Description = "Room 101",
			RoomTypeId = RoomTypeSeeds.RoomType1.Id
		};

        public static readonly Room Room2 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca22"),
            RoomNumber = "102",
            Description = "Room 102",
			RoomTypeId = RoomTypeSeeds.RoomType2.Id
		};

        public static readonly Room Room3 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca23"),
            RoomNumber = "103",
            Description = "Room 103",
			RoomTypeId = RoomTypeSeeds.RoomType3.Id
		};

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                Room1, Room2, Room3
            );
        }
    }
}
