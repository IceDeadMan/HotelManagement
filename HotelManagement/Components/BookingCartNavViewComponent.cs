using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services;

/// <summary>
/// BookingCartNavViewComponent is a view component that displays the number of rooms in the booking cart.
/// It retrieves the cart from the BookingCartService and counts the number of room IDs in it.
/// </summary>
public class BookingCartNavViewComponent : ViewComponent
{
    private readonly BookingCartService _bookingCartService;

    public BookingCartNavViewComponent(BookingCartService bookingCartService)
    {
        _bookingCartService = bookingCartService;
    }

    public IViewComponentResult Invoke()
    {
        var cart = _bookingCartService.GetCart();
        var count = cart.RoomIds?.Count ?? 0;
        return View(count);
    }
}

