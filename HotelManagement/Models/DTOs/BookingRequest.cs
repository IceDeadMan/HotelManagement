namespace HotelManagement.Models.DTOs
{
	/// <summary>
	/// Represents a request to book a room for a specific period.
	/// </summary>
	public class BookingRequest
	{
		public Guid RoomId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
