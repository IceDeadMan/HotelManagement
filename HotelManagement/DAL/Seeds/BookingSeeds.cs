using HotelManagement.Enums;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public static class BookingSeeds
    {
        public static readonly Booking Booking1 = new Booking
        {
            Id = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611901"),
            StartDate = new DateTime(2025, 5, 1),
            EndDate = new DateTime(2025, 5, 5),
            Status = BookingStatus.Confirmed,
            ApplicationUserId = UserSeeds.User1.Id
        };

        public static readonly Booking Booking2 = new Booking
        {
            Id = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611902"),
            StartDate = new DateTime(2025, 6, 11),
            EndDate = new DateTime(2025, 6, 15),
            Status = BookingStatus.Pending,
            ApplicationUserId = UserSeeds.User1.Id
        };

        public static readonly Booking Booking3 = new Booking
        {
            Id = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611903"),
            StartDate = new DateTime(2025, 7, 10),
            EndDate = new DateTime(2025, 7, 15),
            Status = BookingStatus.Pending,
            ApplicationUserId = UserSeeds.User6.Id
        };

        public static readonly Booking Booking4 = new Booking
        {
            Id = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611904"),
            StartDate = new DateTime(2024, 8, 3),
            EndDate = new DateTime(2024, 8, 6),
            Status = BookingStatus.Cancelled,
            ApplicationUserId = UserSeeds.User7.Id
        };

        public static readonly Booking Booking5 = new Booking
        {
            Id = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611905"),
            StartDate = new DateTime(2024, 9, 20),
            EndDate = new DateTime(2024, 9, 25),
            Status = BookingStatus.Completed,
            ApplicationUserId = UserSeeds.User6.Id
        };

        public static readonly Booking Booking6 = new Booking
        {
            Id = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611906"),
            StartDate = new DateTime(2025, 10, 5),
            EndDate = new DateTime(2025, 10, 10),
            Status = BookingStatus.Pending,
            ApplicationUserId = UserSeeds.User7.Id
        };

        public static readonly Booking Booking7 = new Booking
        {
            Id = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611907"),
            StartDate = new DateTime(2025, 6, 5),
            EndDate = new DateTime(2025, 6, 11),
            Status = BookingStatus.Confirmed,
            ApplicationUserId = UserSeeds.User7.Id
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(
                Booking1, Booking2, Booking3, Booking4, Booking5, Booking6, Booking7
            );

            modelBuilder.Entity("RoomBookings").HasData(
                new { BookingsId = Booking1.Id, RoomsId = RoomSeeds.Room1.Id },
                new { BookingsId = Booking1.Id, RoomsId = RoomSeeds.Room2.Id },
                new { BookingsId = Booking2.Id, RoomsId = RoomSeeds.Room1.Id },
                new { BookingsId = Booking3.Id, RoomsId = RoomSeeds.Room4.Id },
                new { BookingsId = Booking3.Id, RoomsId = RoomSeeds.Room5.Id },
                new { BookingsId = Booking4.Id, RoomsId = RoomSeeds.Room3.Id },
                new { BookingsId = Booking5.Id, RoomsId = RoomSeeds.Room6.Id },
                new { BookingsId = Booking6.Id, RoomsId = RoomSeeds.Room7.Id },
                new { BookingsId = Booking6.Id, RoomsId = RoomSeeds.Room8.Id },
                new { BookingsId = Booking7.Id, RoomsId = RoomSeeds.Room13.Id }
            );
        }
    }
}
