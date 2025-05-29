using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using Tests.TestUtilities;

namespace Tests.RepositoryTests
{
    public class RoomTypeRepositoryTests : IClassFixture<DbContextFixture>
    {
        public readonly HotelManagementDbContext _context;
        public readonly RoomTypeRepository _roomTypeRepository;

        public RoomTypeRepositoryTests(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _roomTypeRepository = new RoomTypeRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededRoomTypes()
        {
            var allRoomTypes = _roomTypeRepository.GetAll();
            Assert.NotEmpty(allRoomTypes);
            Assert.Contains(allRoomTypes, rt => rt.Name == "Single");
        }

        [Fact]
        public void GetById_SeededRoomType()
        {
            var roomTypeId = Guid.Parse("fbf96b7e-04d2-4290-82e7-40a6f1c76b51");
            var roomType = _roomTypeRepository.GetById(roomTypeId);

            Assert.NotNull(roomType);
            Assert.Equal("Single", roomType.Name);
        }

        [Fact]
        public void Delete_SeededRoomType()
        {
            var roomTypeId = Guid.Parse("fbf96b7e-04d2-4290-82e7-40a6f1c76b54");
            var roomType = _roomTypeRepository.GetById(roomTypeId);
            Assert.NotNull(roomType);

            _roomTypeRepository.Delete(roomTypeId);
            var deletedRoomType = _roomTypeRepository.GetById(roomTypeId);

            Assert.Null(deletedRoomType);
        }
    }
}
