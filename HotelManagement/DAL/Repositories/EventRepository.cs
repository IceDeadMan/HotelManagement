using HotelManagement.Models;
using HotelManagement.Models.JoinEntities;
using Microsoft.EntityFrameworkCore;

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
            var eventItem = _context.Events
                .Include(e => e.StaffMembers)
                .FirstOrDefault(e => e.Id == eventId);

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

        public void UnassignStaffFromEvent(Guid eventId, Guid userId)
        {
            var eventItem = _context.Events.Include(e => e.StaffMembers)
                .FirstOrDefault(e => e.Id == eventId);

            if (eventItem != null)
            {
                var user = eventItem.StaffMembers.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    eventItem.StaffMembers.Remove(user);
                    Update(eventItem);
                }
                else
                {
                    throw new Exception("User not assigned to this event");
                }
            }
            else
            {
                throw new Exception("Event not found");
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

        public void UnregisterUserFromEvent(Guid eventId, Guid userId)
        {
            var registration = _context.EventRegistrations
                .FirstOrDefault(r => r.EventId == eventId && r.UserId == userId);

            if (registration != null)
            {
                _context.EventRegistrations.Remove(registration);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Registration not found");
            }
        }

        public bool IsUserRegisteredToEvent(Guid eventId, Guid userId)
        {
            return _context.EventRegistrations.Any(r => r.EventId == eventId && r.UserId == userId);
        }

        public Event? GetByIdWithDetails(Guid id)
        {
            return _context.Events
                .Include(e => e.StaffMembers)
                .Include(e => e.Registrations)
                .ThenInclude(r => r.User)
                .FirstOrDefault(e => e.Id == id);
        }

        public async Task<List<Event>> GetAllWithDetailsAsync()
        {
            return await _context.Events
                .Include(e => e.StaffMembers)
                .Include(e => e.Registrations)
                .ThenInclude(r => r.User)
                .ToListAsync();
        }
    }
}
