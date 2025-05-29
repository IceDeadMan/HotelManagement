using Microsoft.AspNetCore.Http;
using System.Text.Json;
using HotelManagement.Models;
using HotelManagement.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HotelManagement.Services
{
	/// <summary>
	/// BookingCartService manages the booking cart for users.
	/// It uses session storage to persist the cart data across requests.
	/// It is used mainy for adding multiple rooms to the booking during different steps of the booking process
	/// The cart contains the start and end dates of the booking and a list of room IDs selected for the booking.
	/// The cart is stored in the session using a unique key based on the user ID for authenticated users.
	/// </summary>
	public class BookingCartService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private const string SessionKey = "BookingCart";

		private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true
		};


		public BookingCartService(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		/// <summary>
		/// Get the session key for the booking cart.
		/// This is based on the user ID for authenticated users.
		/// </summary>
		/// <returns> The session key for the booking cart. </returns>
		private string GetSessionKey()
		{
			var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			return userId != null ? $"BookingCart_{userId}" : SessionKey; // fallback to shared for anon
		}


		public BookingCartSession GetCart()
		{
			var key = GetSessionKey();
			var data = _httpContextAccessor.HttpContext.Session.GetString(key);
			return data == null ? new BookingCartSession() : JsonSerializer.Deserialize<BookingCartSession>(data, _jsonOptions);
		}


		public void SaveCart(BookingCartSession cart)
		{
			var key = GetSessionKey();
			var data = JsonSerializer.Serialize(cart, _jsonOptions);
			_httpContextAccessor.HttpContext.Session.SetString(key, data);
		}

		public void ClearCart()
		{
			var key = GetSessionKey();
			_httpContextAccessor.HttpContext.Session.Remove(key);
		}
	}
}

