using Microsoft.AspNetCore.Http;
using System.Text.Json;
using HotelManagement.Models;
using HotelManagement.Models.DTOs;

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

		public BookingCartSession GetCart()
		{
			var session = _httpContextAccessor.HttpContext.Session;
			var data = session.GetString(SessionKey);
			return data == null ? new BookingCartSession() : JsonSerializer.Deserialize<BookingCartSession>(data, _jsonOptions);
		}

		public void SaveCart(BookingCartSession cart)
		{
			var session = _httpContextAccessor.HttpContext.Session;
			var data = JsonSerializer.Serialize(cart, _jsonOptions);
			session.SetString(SessionKey, data);
		}

		public void ClearCart()
		{
			_httpContextAccessor.HttpContext.Session.Remove(SessionKey);
		}
	}
}

