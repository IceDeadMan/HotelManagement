namespace HotelManagement.Models
{
    public class Event
    {
        public Guid Id { get; init; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }

        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
