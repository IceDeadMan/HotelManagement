using HotelManagement.Models;
using HotelManagement.Models.JoinEntities;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    /// <summary>
    /// Provides seed data for events in the hotel management system.
    /// Includes join entities for event registrations and event staff.
    /// </summary>
    public class EventSeeds
    {
        public static readonly Event Event1 = new Event
        {
            Id = Guid.Parse("5a6da81a-74a0-4d50-8cac-fea2f7897731"),
            Name = "Oldies Party",
            Description = "A night of nostalgia with classic hits.",
            Capacity = 100,
            Date = new DateTime(2025, 6, 15),
        };

        public static readonly Event Event2 = new Event
        {
            Id = Guid.Parse("6b7da81a-74a0-4d50-8cac-fea2f7897732"),
            Name = "Jazz Night",
            Description = "Enjoy a relaxing evening with smooth jazz.",
            Capacity = 50,
            Date = new DateTime(2025, 11, 20),
        };
        
        public static readonly Event Event3 = new Event
        {
            Id = Guid.Parse("7c8da81a-74a0-4d50-8cac-fea2f7897733"),
            Name = "Wine Tasting Evening",
            Description = "Sample exquisite wines from around the world.",
            Capacity = 30,
            Date = new DateTime(2025, 6, 13),
        };

        public static readonly Event Event4 = new Event
        {
            Id = Guid.Parse("8d9da81a-74a0-4d50-8cac-fea2f7897734"),
            Name = "Live Comedy Show",
            Description = "An evening of laughs with stand-up comedians.",
            Capacity = 200,
            Date = new DateTime(2025, 8, 15),
        };

        public static readonly Event Event5 = new Event
        {
            Id = Guid.Parse("9e0da81a-74a0-4d50-8cac-fea2f7897735"),
            Name = "Poolside BBQ Bash",
            Description = "Join us for a summer BBQ party by the pool.",
            Capacity = 5,
            Date = new DateTime(2025, 9, 10),
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                Event1, Event2, Event3, Event4, Event5
            );

            // Event registrations
            modelBuilder.Entity<EventRegistration>().HasData(
                new { EventId = Event1.Id, UserId = UserSeeds.User1.Id, NumberOfParticipants = 2 },
                new { EventId = Event3.Id, UserId = UserSeeds.User6.Id, NumberOfParticipants = 1 },
                new { EventId = Event4.Id, UserId = UserSeeds.User1.Id, NumberOfParticipants = 3 },
                new { EventId = Event4.Id, UserId = UserSeeds.User7.Id, NumberOfParticipants = 2 },
                new { EventId = Event5.Id, UserId = UserSeeds.User6.Id, NumberOfParticipants = 1 }
            );

            // Event staff
            modelBuilder.Entity("EventStaff").HasData(
                new { EventId = Event1.Id, UserId = UserSeeds.User3.Id },
                new { EventId = Event3.Id, UserId = UserSeeds.User3.Id },
                new { EventId = Event4.Id, UserId = UserSeeds.User8.Id },
                new { EventId = Event5.Id, UserId = UserSeeds.User3.Id },
                new { EventId = Event5.Id, UserId = UserSeeds.User8.Id }
            );
        }
    }
}
