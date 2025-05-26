using System;
using HotelManagement.Models.DTOs;

namespace HotelManagement.ViewModels;

/// <summary>
/// ViewModel for the reception desk to display booking summaries.
/// </summary>
public class ReceptionViewModel
{
    public List<ReceptionBookingSummary> TodaysBookings { get; set; } = new();
    public List<ReceptionBookingSummary> OngoingBookings { get; set; } = new();
    public List<ReceptionBookingSummary> BeforeCheckIn { get; set; } = new();
    public List<ReceptionBookingSummary> PastOrCancelledBookings { get; set; } = new();
}
