using HotelManagement.DAL;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Services
{
    /// <summary>
    /// Service to seed room type images into the database.
    /// This is done seperately from the initial seeding of data,
    /// due to the need of dynamically loading images from the file system and serializing them into the database.
    /// </summary>
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
