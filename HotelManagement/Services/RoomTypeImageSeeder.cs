using HotelManagement.DAL;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Services
{
    public class RoomTypeImageSeeder
    {
        public static async Task SeedImagesAsync(HotelManagementDbContext context)
        {
            var roomTypes = await context.RoomTypes.ToListAsync();

            foreach (var roomType in roomTypes)
            {
                if (roomType.Photo != null) continue;

                string fileName = $"Resources/SeedImages/{roomType.Name}.jpg";
                if (File.Exists(fileName))
                {
                    roomType.Photo = await File.ReadAllBytesAsync(fileName);
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
