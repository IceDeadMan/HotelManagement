namespace HotelManagement.Models.JoinEntities
{
    /// <summary>
    /// Represents a registration for an event by a user.
    /// Includes the detail of the event and the user, as well as the number of participants.
    /// </summary>
    public class EventRegistration
    {
        public Guid EventId { get; set; }
        public Event? Event { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int NumberOfParticipants { get; set; }
    }
}
