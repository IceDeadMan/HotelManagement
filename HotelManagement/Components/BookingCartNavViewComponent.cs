// Components/BookingCartNavViewComponent.cs
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services;

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

