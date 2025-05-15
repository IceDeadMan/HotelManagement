namespace HotelManagement.Models.DTOs
{
	public class BookingCartSession
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<Guid> RoomIds { get; set; } = new();
	}
}
