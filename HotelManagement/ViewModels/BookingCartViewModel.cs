namespace HotelManagement.ViewModels
{

    /// <summary>
    /// BookingCartViewModel is used to represent the booking cart details.
    /// It contains the start and end dates of the booking, total nights,
    /// total price, and a list of room details included in the booking.
    /// </summary>
    public class BookingCartViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Nights { get; set; }
        public decimal TotalPrice { get; set; }

        public List<RoomCartItem> RoomDetails { get; set; } = new();

        public class RoomCartItem
        {
            public string RoomId { get; set; }
            public string RoomNumber { get; set; }

            public string RoomTypeDescription { get; set; }
            public int Capacity { get; set; }

            public decimal PricePerNight { get; set; }
            public decimal Subtotal { get; set; }
        }
    }
}

