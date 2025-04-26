using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Seeds
{
    public class EventSeeds
    {
        public static readonly Event Event1 = new Event
        {
            Id = Guid.Parse("5a6da81a-74a0-4d50-8cac-fea2f7897731"),
            Name = "Oldies Party",
            Description = "A night of nostalgia with classic hits.",
            Date = new DateTime(2023, 10, 15),
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                Event1
            );

            // Add users to event
            modelBuilder.Entity("EventUsers").HasData(
                new { EventsId = Event1.Id, UsersId = UserSeeds.User1.Id },
                new { EventsId = Event1.Id, UsersId = UserSeeds.User2.Id }
            );
        }
    }
}
