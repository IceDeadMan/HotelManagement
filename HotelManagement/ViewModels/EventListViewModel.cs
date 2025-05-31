using System;

namespace HotelManagement.ViewModels;

public class EventListViewModel
{
    public List<EventListItemViewModel> Events { get; set; } = new();
    public bool IsManager { get; set; }
    public string? CurrentUserId { get; set; }
}