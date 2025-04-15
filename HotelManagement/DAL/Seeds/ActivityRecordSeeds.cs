using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public class ActivityRecordSeeds
    {
        public static readonly ActivityRecord ActivityRecord1 = new ActivityRecord
        {
            Id = Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"),
            Date = new DateTime(2023, 10, 1),
            Description = "Room 101 cleaning",
            Type = Enums.ActivityType.Cleaning,
            Status = Enums.ActivityStatus.Planned,
            RoomId = RoomSeeds.Room1.Id,
            ApplicationUserId = UserSeeds.User1.Id
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityRecord>().HasData(ActivityRecord1);
        }
    }
}
