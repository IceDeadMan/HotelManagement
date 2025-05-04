using HotelManagement.Enums;

namespace HotelManagement.Helpers
{
	public static class RoomTypeHelper
	{
		public static readonly Dictionary<RoomType, (string Name, string Description, int Capacity)> Details =
			new()
			{
			{ RoomType.Single, ("Single Room", "A cozy room for one person", 1) },
			{ RoomType.Double, ("Double Room", "Comfortable for two guests", 2) },
			{ RoomType.Suite, ("Suite", "Luxury suite with extra amenities", 4) },
			{ RoomType.Familly, ("Family Room", "Spacious room for families", 6) }
			};

		public static string GetName(RoomType type) => Details[type].Name;
		public static string GetDescription(RoomType type) => Details[type].Description;
		public static int GetCapacity(RoomType type) => Details[type].Capacity;
	}

}
