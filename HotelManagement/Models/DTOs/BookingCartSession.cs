namespace HotelManagement.Models.DTOs
{
	/// <summary>
	/// Represents a session for a booking cart.
	/// /// This class is used to store the start and end dates of the booking,
	/// as well as the list of room IDs selected for the booking.
	/// </summary>
	public class BookingCartSession
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<Guid> RoomIds { get; set; } = new();
	}
}
