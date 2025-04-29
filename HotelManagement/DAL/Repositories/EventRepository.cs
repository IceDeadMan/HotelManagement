using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public Guid AddUserToEvent(Guid eventId, Guid userId)
        {
            var user = _context.Users.Find(userId);
            var eventItem = _context.Events.Find(eventId);

            if (user != null && eventItem != null)
            {
                eventItem.Users.Add(user);
                Update(eventItem);

                return eventItem.Id;
            }
            else
            {
                throw new Exception("User or Event not found");
            }
        }
    }
}
