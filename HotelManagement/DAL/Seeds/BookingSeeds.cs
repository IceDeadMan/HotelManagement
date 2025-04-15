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

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(Booking1);

            // Seed the join table between rooms and bookings
            modelBuilder.Entity("RoomBookings").HasData(
                new { BookingsId = Booking1.Id, RoomsId = RoomSeeds.Room1.Id },
                new { BookingsId = Booking1.Id, RoomsId = RoomSeeds.Room2.Id }
            );
        }
    }
}
