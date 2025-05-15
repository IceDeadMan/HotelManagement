namespace HotelManagement.Models.DTOs
{
	public class BookingRequest
	{
		public Guid RoomId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
