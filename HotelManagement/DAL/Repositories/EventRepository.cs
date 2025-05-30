using HotelManagement.Models;
using HotelManagement.Models.JoinEntities;

namespace HotelManagement.DAL.Repositories
{
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public Guid AssignStaffToEvent(Guid eventId, Guid userId)
        {
            var user = _context.Users.Find(userId);
            var eventItem = _context.Events.Find(eventId);

            if (user != null && eventItem != null)
            {
                eventItem.StaffMembers.Add(user);
                Update(eventItem);

                return eventItem.Id;
            }
            else
            {
                throw new Exception("User or Event not found");
            }
        }

        public Guid RegisterUserToEvent(Guid eventId, Guid userId, int numberOfParticipants)
        {
            var user = _context.Users.Find(userId);
            var eventItem = _context.Events.Find(eventId);

            if (user != null && eventItem != null)
            {
                var registration = new EventRegistration
                {
                    EventId = eventId,
                    UserId = userId,
                    NumberOfParticipants = numberOfParticipants
                };

                _context.EventRegistrations.Add(registration);
                _context.SaveChanges();

                return eventItem.Id;
            }
            else
            {
                throw new Exception("User or Event not found");
            }
        }
    }
}
