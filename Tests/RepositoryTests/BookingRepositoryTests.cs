using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using Tests.TestUtilities;
using HotelManagement.Enums;
using HotelManagement.Models;
using HotelManagement.DAL.Seeds;

namespace Tests.RepositoryTests
{
    public class BookingRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly HotelManagementDbContext _context;
        private readonly BookingRepository _bookingRepository;
        private readonly RoomRepository _roomRepository;
        public BookingRepositoryTests(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _bookingRepository = new BookingRepository(_context);
            _roomRepository = new RoomRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededBookings()
        {
            var allBookings = _bookingRepository.GetAll();

            Assert.NotEmpty(allBookings);
            Assert.Contains(allBookings, b => b.Id == Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611901"));
        }

        [Fact]
        public void GetById_ReturnsBooking()
        {
            var bookingId = Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611901");
            var booking = _bookingRepository.GetById(bookingId);

            Assert.NotNull(booking);
            Assert.Equal(BookingStatus.Confirmed, booking.Status);
        }

        [Fact]
        public void Create_NewEmptyBooking()
        {
            var newBooking = new Booking
            {
                StartDate = new DateTime(2025, 6, 1),
                EndDate = new DateTime(2025, 6, 5),
                Status = BookingStatus.Pending,
                ApplicationUserId = UserSeeds.User1.Id
            };

            var newBookingId = _bookingRepository.Create(newBooking);
            var createdBooking = _bookingRepository.GetById(newBookingId);
            var user = _context.Users.Find(UserSeeds.User1.Id);

            Assert.NotNull(createdBooking);
            Assert.Equal(BookingStatus.Pending, createdBooking.Status);
            Assert.NotNull(user);
            Assert.Contains(user.Bookings, b => b.Id == newBookingId);
        }

        [Fact]
        public void Create_NewBookingWithRooms()
        {
            var room1 = _roomRepository.GetById(Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca21"));
            var room2 = _roomRepository.GetById(Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca22"));

            Assert.NotNull(room1);
            Assert.NotNull(room2);

            var newBooking = new Booking
            {
                StartDate = new DateTime(2025, 7, 1),
                EndDate = new DateTime(2025, 7, 5),
                Status = BookingStatus.Pending,
                ApplicationUserId = UserSeeds.User1.Id,
                Rooms = new List<Room>
                {
                    room1,
                    room2
                }
            };

            var newBookingId = _bookingRepository.Create(newBooking);
            var createdBooking = _bookingRepository.GetById(newBookingId);

            var updatedRoom1 = _roomRepository.GetById(room1.Id);
            var updatedRoom2 = _roomRepository.GetById(room2.Id);

            Assert.NotNull(createdBooking);
            Assert.Equal(2, createdBooking.Rooms.Count);
            Assert.Contains(createdBooking.Rooms, r => r.Id == room1.Id);
            Assert.Contains(createdBooking.Rooms, r => r.Id == room2.Id);
            Assert.NotNull(updatedRoom1);
            Assert.Contains(updatedRoom1.Bookings, b => b.Id == newBookingId);
            Assert.NotNull(updatedRoom2);
            Assert.Contains(updatedRoom2.Bookings, b => b.Id == newBookingId);
        }

        [Fact]
        public void Update_ExistingBooking()
        {
            var bookingToUpdate = _bookingRepository.GetById(Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611901"));

            Assert.NotNull(bookingToUpdate);

            bookingToUpdate.Status = BookingStatus.Cancelled;
            _bookingRepository.Update(bookingToUpdate);
            var updatedBooking = _bookingRepository.GetById(bookingToUpdate.Id);

            Assert.NotNull(updatedBooking);
            Assert.Equal(BookingStatus.Cancelled, updatedBooking.Status);
        }

        [Fact]
        public void Delete_ExistingBooking()
        {
            var bookingToDelete = _bookingRepository.GetById(Guid.Parse("371c096d-5c0b-4929-aab5-1c0289611902"));

            Assert.NotNull(bookingToDelete);

            _bookingRepository.Delete(bookingToDelete.Id);
            var deletedBooking = _bookingRepository.GetById(bookingToDelete.Id);
            var user = _context.Users.Find(UserSeeds.User1.Id);

            Assert.Null(deletedBooking);
            Assert.NotNull(user);
            Assert.DoesNotContain(user.Bookings, b => b.Id == bookingToDelete.Id);
        }
    }
}
