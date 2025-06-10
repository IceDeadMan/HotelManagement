using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using HotelManagement.Models;
using Tests.TestUtilities;

namespace Tests.RepositoryTests
{
    public class RoomRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly HotelManagementDbContext _context;
        private readonly RoomRepository _roomRepository;

        public RoomRepositoryTests(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _roomRepository = new RoomRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededRooms()
        {
            var allRooms = _roomRepository.GetAll();

            Assert.NotEmpty(allRooms);
            Assert.Contains(allRooms, r => r.RoomNumber == "101");
        }

        [Fact]
        public void GetById_ReturnsRoom()
        {
            var roomId = Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca21");
            var room = _roomRepository.GetById(roomId);

            Assert.NotNull(room);
            Assert.Equal("101", room.RoomNumber);
        }

        [Fact]
        public void Create_NewRoom()
        {
            var newRoom = new Room
            {
                RoomNumber = "104",
                Description = "Testing Room"
            };

            var newRoomId = _roomRepository.Create(newRoom);
            var createdRoom = _roomRepository.GetById(newRoomId);

            Assert.NotNull(createdRoom);
            Assert.Equal("104", createdRoom.RoomNumber);
        }

        [Fact]
        public void Update_ExistingRoom()
        {
            var roomToUpdate = _roomRepository.GetById(Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca21"));

            Assert.NotNull(roomToUpdate);

            roomToUpdate.Description = "Updated Description";
            var updatedRoomId = _roomRepository.Update(roomToUpdate) ?? Guid.NewGuid();
            var updatedRoom = _roomRepository.GetById(updatedRoomId);

            Assert.NotNull(updatedRoom);
            Assert.Equal("Updated Description", updatedRoom.Description);
        }

        [Fact]
        public void Delete_ExistingRoom()
        {
            var roomToDelete = _roomRepository.GetById(Guid.Parse("a242ae42-b5f3-417e-9277-b89ac16fca23"));

            Assert.NotNull(roomToDelete);

            _roomRepository.Delete(roomToDelete.Id);
            var deletedRoom = _roomRepository.GetById(roomToDelete.Id);

            Assert.Null(deletedRoom);
        }
    }
}
