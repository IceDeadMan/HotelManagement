using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    /// <summary>
    /// Seeds initial data for rooms in the database.
    /// </summary>
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

        public static readonly Room Room4 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca24"),
            RoomNumber = "104",
            Description = "Room 104",
            RoomTypeId = RoomTypeSeeds.RoomType4.Id
        };

        public static readonly Room Room5 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca25"),
            RoomNumber = "105",
            Description = "Room 105",
            RoomTypeId = RoomTypeSeeds.RoomType1.Id
        };

        public static readonly Room Room6 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca26"),
            RoomNumber = "106",
            Description = "Room 106",
            RoomTypeId = RoomTypeSeeds.RoomType2.Id
        };

        public static readonly Room Room7 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca27"),
            RoomNumber = "107",
            Description = "Room 107",
            RoomTypeId = RoomTypeSeeds.RoomType3.Id
        };

        public static readonly Room Room8 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca28"),
            RoomNumber = "108",
            Description = "Room 108",
            RoomTypeId = RoomTypeSeeds.RoomType4.Id
        };

        public static readonly Room Room9 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca29"),
            RoomNumber = "109",
            Description = "Room 109",
            RoomTypeId = RoomTypeSeeds.RoomType1.Id
        };

        public static readonly Room Room10 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca30"),
            RoomNumber = "110",
            Description = "Room 110",
            RoomTypeId = RoomTypeSeeds.RoomType2.Id
        };

        public static readonly Room Room11 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca31"),
            RoomNumber = "111",
            Description = "Room 111",
            RoomTypeId = RoomTypeSeeds.RoomType3.Id
        };

        public static readonly Room Room12 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca32"),
            RoomNumber = "112",
            Description = "Room 112",
            RoomTypeId = RoomTypeSeeds.RoomType4.Id
        };

        public static readonly Room Room13 = new Room
        {
            Id = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca33"),
            RoomNumber = "113",
            Description = "Room 113",
            RoomTypeId = RoomTypeSeeds.RoomType1.Id
        };


        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                Room1, Room2, Room3, Room4, Room5, Room6, Room7, Room8, Room9, Room10, Room11, Room12, Room13
            );
        }
    }
}
