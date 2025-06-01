namespace HotelManagement.Models.JoinEntities
{
    public class EventRegistration
    {
        public Guid EventId { get; set; }
        public Event? Event { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int NumberOfParticipants { get; set; }
    }
}
