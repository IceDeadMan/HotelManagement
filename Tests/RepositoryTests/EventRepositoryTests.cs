using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using HotelManagement.DAL.Seeds;
using HotelManagement.Models;
using Tests.TestUtilities;

namespace Tests.RepositoryTests
{
    public class EventRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly HotelManagementDbContext _context;
        private readonly EventRepository _eventRepository;
        public EventRepositoryTests(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _eventRepository = new EventRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededEvents()
        {
            var allEvents = _eventRepository.GetAll();

            Assert.NotEmpty(allEvents);
            Assert.Contains(allEvents, e => e.Name == "Oldies Party");
        }

        [Fact]
        public void GetById_SeededEvent()
        {
            var eventId = Guid.Parse("5a6da81a-74a0-4d50-8cac-fea2f7897731");
            var eventItem = _eventRepository.GetById(eventId);

            Assert.NotNull(eventItem);
            Assert.Equal("Oldies Party", eventItem.Name);
        }

        [Fact]
        public void Create_NewEvent()
        {
            var newEvent = new Event
            {
                Name = "New Year Party",
                Description = "Celebrate the New Year with us!",
                Date = new DateTime(2026, 1, 1)
            };
            var newEventId = _eventRepository.Create(newEvent);
            var createdEvent = _eventRepository.GetById(newEventId);

            Assert.NotNull(createdEvent);
            Assert.Equal("New Year Party", createdEvent.Name);
        }

        [Fact]
        public void Update_ExistingEvent()
        {
            var eventToUpdate = _eventRepository.GetById(Guid.Parse("5a6da81a-74a0-4d50-8cac-fea2f7897731"));

            Assert.NotNull(eventToUpdate);

            eventToUpdate.Description = "Updated Description";
            _eventRepository.Update(eventToUpdate);
            var updatedEvent = _eventRepository.GetById(eventToUpdate.Id);

            Assert.NotNull(updatedEvent);
            Assert.Equal("Updated Description", updatedEvent.Description);
        }

        [Fact]
        public void Assign_Staff_To_Event()
        {
            var eventItem = _eventRepository.GetById(Guid.Parse("6b7da81a-74a0-4d50-8cac-fea2f7897732"));
            var staff = _context.Users.Find(UserSeeds.User3.Id);

            Assert.NotNull(eventItem);
            Assert.NotNull(staff);

            var updatedEventId = _eventRepository.AssignStaffToEvent(eventItem.Id, staff.Id);
            var updatedEvent = _eventRepository.GetById(updatedEventId);

            Assert.NotNull(updatedEvent);
            Assert.Contains(updatedEvent.StaffMembers, u => u.Id == staff.Id);
        }

        [Fact]
        public void Register_User_To_Event_With_Participants()
        {
            var eventItem = _eventRepository.GetById(Guid.Parse("6b7da81a-74a0-4d50-8cac-fea2f7897732"));
            var user = _context.Users.Find(UserSeeds.User1.Id);

            Assert.NotNull(eventItem);
            Assert.NotNull(user);

            var updatedEventId = _eventRepository.RegisterUserToEvent(eventItem.Id, user.Id, 2);
            var registrations = _context.EventRegistrations
                .Where(r => r.EventId == updatedEventId && r.UserId == user.Id)
                .ToList();

            Assert.Single(registrations);
            Assert.Equal(2, registrations.First().NumberOfParticipants);
        }
    }
}
