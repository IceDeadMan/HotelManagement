namespace HotelManagement.Models
{
    public class RoomType : BaseModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }

        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
