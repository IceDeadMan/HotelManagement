using HotelManagement.DAL.Repositories;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelManagement.Services;
using HotelManagement.Models.DTOs;

namespace HotelManagement.Controllers
{
	public class BookingsController : Controller
	{
		private readonly ILogger<BookingsController> _logger;
		private readonly RoomTypeRepository _roomTypeRepository;
		private readonly BookingCartService _bookingCartService;

		public BookingsController(ILogger<BookingsController> logger, RoomTypeRepository roomTypeRepository, BookingCartService bookingCartService)
		{
			_logger = logger;
			_roomTypeRepository = roomTypeRepository;
			_bookingCartService = bookingCartService;
		}

		// View for starting a new booking with filters
		public async Task<IActionResult> StartBooking()
		{
			var cart = _bookingCartService.GetCart();
			var roomIdsInCart = cart.RoomIds;
			var startCart = cart.StartDate;
			var endCart = cart.EndDate;
			var roomTypes = await _roomTypeRepository.GetAllAsync();
			ViewBag.RoomIdsInCart = roomIdsInCart;
			ViewBag.StartCart = startCart;
			ViewBag.EndCart = endCart;
			return View(roomTypes);
		}

		//[HttpPost]
		//public async Task<IActionResult> FilterRooms(DateTime startDate, DateTime endDate, RoomType? roomType)
		//{
		//	var availableRooms = await _roomRepository.GetAvailableRoomsAsync(startDate, endDate, roomType);
		//	return PartialView("_RoomCardsPartial", availableRooms);
		//}

		// Add room to booking cart
		[HttpPost]
		public IActionResult AddToBookingCart([FromBody] BookingRequest dto)
		{
			if (dto.StartDate > dto.EndDate)
			{
				return BadRequest("Invalid date range.");
			}

			var cart = _bookingCartService.GetCart();

			_logger.LogInformation("DTO StartDate: {StartDate}, EndDate: {EndDate}", dto.StartDate, dto.EndDate);
			_logger.LogInformation("Room Count: {RoomCount}", cart.RoomIds.Count);
			if (cart.RoomIds.Count == 0)
			{
				cart.StartDate = dto.StartDate;
				cart.EndDate = dto.EndDate;
			}
			else if (cart.StartDate != dto.StartDate || cart.EndDate != dto.EndDate)
			{
				return BadRequest("Stay duration must be the same for all rooms.");
			}
			_logger.LogInformation("Cart start date: {StartDate}, end date: {EndDate}", cart.StartDate, cart.EndDate);
			if (!cart.RoomIds.Contains(dto.RoomId))
			{
				cart.RoomIds.Add(dto.RoomId);
			}

			_bookingCartService.SaveCart(cart);
			return Json(new { success = true });
		}

		[HttpPost]
		public IActionResult RemoveFromBookingCart([FromBody] BookingRequest dto)
		{
			Console.WriteLine($"Removing Room: {dto.RoomId}");
			var cart = _bookingCartService.GetCart();
			if (cart.RoomIds.Contains(dto.RoomId))
			{
				Console.WriteLine($"Removing Room: {dto.RoomId}");
				cart.RoomIds.Remove(dto.RoomId);
				_bookingCartService.SaveCart(cart);
			}
			return Json(new { success = true });
		}

	}
}

