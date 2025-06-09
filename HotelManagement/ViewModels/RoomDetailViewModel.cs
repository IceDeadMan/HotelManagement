namespace HotelManagement.ViewModels
{

    /// <summary>
    /// Represents the details of a room to display on the RommDetail page.
    /// </summary>
    public class RoomDetailViewModel
    {
        public Guid Id { get; set; }
        public string RoomNumber { get; set; } = "";
        public string Description { get; set; } = "";

        public string RoomTypeName { get; set; } = "";
        public string RoomTypeDescription { get; set; } = "";
        public int RoomTypeCapacity { get; set; }
        public decimal RoomTypePrice { get; set; }
        public byte[]? RoomTypePhoto { get; set; }

        public List<BookingSummaryViewModel> Bookings { get; set; } = new();
        public List<ActivityRecordViewModel> Activities { get; set; } = new();
        public List<ReviewViewModel> Reviews { get; set; } = new();
    }
}
