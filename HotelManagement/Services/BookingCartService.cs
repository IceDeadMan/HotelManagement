using Microsoft.AspNetCore.Http;
using System.Text.Json;
using HotelManagement.Models;
using HotelManagement.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HotelManagement.Services
{
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
		/// <returns></returns>
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

