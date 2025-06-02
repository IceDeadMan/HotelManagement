using HotelManagement.Enums;

namespace HotelManagement.ViewModels.DTOs;

/// <summary>
/// Represents a summary of a booking for the reception desk.
/// </summary>
public class ReceptionBookingSummary
{
    public Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public BookingStatus Status { get; set; }

    public string UserName { get; set; }
    public List<string> RoomNumbers { get; set; }
}
