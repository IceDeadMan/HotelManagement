namespace HotelManagement.Models
{
    public class Room
    {
        public Guid Id { get; init; }
        public string? RoomNumber { get; set; }
        public string? Description { get; set; }
    }
}
