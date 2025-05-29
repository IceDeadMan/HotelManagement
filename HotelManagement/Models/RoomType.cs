namespace HotelManagement.Models
{
    /// <summary>
    /// Room Type class represents a type of room in the hotel management system.
    /// This class is used to track the name, description, capacity, and price of the room type,
    /// as well as the associated rooms of the room type.
    /// </summary>
    public class RoomType : BaseModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }

        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
