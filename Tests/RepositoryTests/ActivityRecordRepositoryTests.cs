using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using HotelManagement.DAL.Seeds;
using HotelManagement.Enums;
using HotelManagement.Models;
using Tests.TestUtilities;

namespace Tests.RepositoryTests
{
    public class ActivityRecordRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly HotelManagementDbContext _context;
        private readonly ActivityRecordRepository _activityRecordRepository;

        public ActivityRecordRepositoryTests(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _activityRecordRepository = new ActivityRecordRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededActivityRecords()
        {
            var allActivityRecords = _activityRecordRepository.GetAll();

            Assert.NotEmpty(allActivityRecords);
            Assert.Contains(allActivityRecords, ar => ar.Id == Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"));
        }

        [Fact]
        public void GetAll_ForSeededUser()
        {
            var userId = UserSeeds.User3.Id;
            var allActivityRecords = _activityRecordRepository.GetByUserId(userId);

            Assert.NotEmpty(allActivityRecords);
            Assert.Contains(allActivityRecords, ar => ar.ApplicationUserId == userId);
        }

        [Fact]
        public void GetAll_ForSeededRoom()
        {
            var roomId = RoomSeeds.Room1.Id;
            var allActivityRecords = _activityRecordRepository.GetByRoomId(roomId);

            Assert.NotEmpty(allActivityRecords);
            Assert.Contains(allActivityRecords, ar => ar.RoomId == roomId);
        }

        [Fact]
        public void GetById_ReturnsActivityRecord()
        {
            var activityRecordId = Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a31");
            var activityRecord = _activityRecordRepository.GetById(activityRecordId);

            Assert.NotNull(activityRecord);
            Assert.Equal(ActivityStatus.Completed, activityRecord.Status);
        }

        [Fact]
        public void Create_NewActivityRecord()
        {
            var newActivityRecord = new ActivityRecord
            {
                Date = new DateTime(2025, 10, 1),
                Description = "Room 101 maintenance",
                Type = ActivityType.Maintenance,
                Status = ActivityStatus.Planned,
                RoomId = RoomSeeds.Room1.Id,
                ApplicationUserId = UserSeeds.User3.Id
            };
            var newActivityRecordId = _activityRecordRepository.Create(newActivityRecord);
            var createdActivityRecord = _activityRecordRepository.GetById(newActivityRecordId);
            var user = _context.Users.Find(UserSeeds.User3.Id);

            Assert.NotNull(createdActivityRecord);
            Assert.Equal("Room 101 maintenance", createdActivityRecord.Description);
            Assert.NotNull(user);
            Assert.Contains(user.ActivityRecords, ar => ar.Id == newActivityRecordId);
        }

        [Fact]
        public void Update_ExistingActivityRecord()
        {
            var activityRecordToUpdate = _activityRecordRepository.GetById(Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"));

            Assert.NotNull(activityRecordToUpdate);

            activityRecordToUpdate.Description = "Updated Description";
            _activityRecordRepository.Update(activityRecordToUpdate);
            var updatedActivityRecord = _activityRecordRepository.GetById(activityRecordToUpdate.Id);

            Assert.NotNull(updatedActivityRecord);
            Assert.Equal("Updated Description", updatedActivityRecord.Description);
        }

        [Fact]
        public void Delete_ExistingActivityRecord()
        {
            var activityRecordToDelete = _activityRecordRepository.GetById(Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a32"));

            Assert.NotNull(activityRecordToDelete);

            _activityRecordRepository.Delete(activityRecordToDelete.Id);
            var deletedActivityRecord = _activityRecordRepository.GetById(activityRecordToDelete.Id);

            Assert.Null(deletedActivityRecord);
        }
    }
}
