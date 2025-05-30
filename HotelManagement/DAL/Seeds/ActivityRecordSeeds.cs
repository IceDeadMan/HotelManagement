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

        public static readonly ActivityRecord ActivityRecord2 = new ActivityRecord
        {
            Id = Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a32"),
            Date = new DateTime(2023, 10, 2),
            Description = "Room 102 maintenance",
            Type = Enums.ActivityType.Maintenance,
            Status = Enums.ActivityStatus.Completed,
            RoomId = RoomSeeds.Room2.Id,
            ApplicationUserId = UserSeeds.User3.Id
        };

        public static readonly ActivityRecord ActivityRecord3 = new ActivityRecord
        {
            Id = Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a33"),
            Date = new DateTime(2024, 10, 2),
            Description = "Room 102 cleaning",
            Type = Enums.ActivityType.Cleaning,
            Status = Enums.ActivityStatus.Planned,
            RoomId = RoomSeeds.Room2.Id,
            ApplicationUserId = UserSeeds.User3.Id
        };

        public static readonly ActivityRecord ActivityRecord4 = new ActivityRecord
        {
            Id = Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a34"),
            Date = new DateTime(2025, 5, 3),
            Description = "Room 101 minibar restock",
            Type = Enums.ActivityType.Other,
            Status = Enums.ActivityStatus.Completed,
            RoomId = RoomSeeds.Room1.Id,
            ApplicationUserId = UserSeeds.User3.Id
        };

        public static readonly ActivityRecord ActivityRecord5 = new ActivityRecord
        {
            Id = Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a35"),
            Date = new DateTime(2025, 7, 12),
            Description = "Room 104 cleaning",
            Type = Enums.ActivityType.Cleaning,
            Status = Enums.ActivityStatus.Completed,
            RoomId = RoomSeeds.Room4.Id,
            ApplicationUserId = UserSeeds.User8.Id
        };

        public static readonly ActivityRecord ActivityRecord6 = new ActivityRecord
        {
            Id = Guid.Parse("db1ae6ab-91a7-4aaf-a08a-4097ce670a36"),
            Date = new DateTime(2025, 9, 22),
            Description = "Room 106 maintenance check",
            Type = Enums.ActivityType.Maintenance,
            Status = Enums.ActivityStatus.Planned,
            RoomId = RoomSeeds.Room6.Id,
            ApplicationUserId = UserSeeds.User3.Id
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityRecord>().HasData(ActivityRecord1, ActivityRecord2, ActivityRecord3,
                                                          ActivityRecord4, ActivityRecord5, ActivityRecord6);
        }
    }
}
