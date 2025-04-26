using HotelManagement.DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace Tests.TestUtilities;

public class DbContextFixture : IDisposable
{
    public HotelManagementDbContext Context { get; }

    public DbContextFixture()
    {
        var options = new DbContextOptionsBuilder<HotelManagementDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        Context = new HotelManagementDbContext(options);

        Context.Database.EnsureDeleted();
        Context.Database.EnsureCreated();
    }

    public void Dispose()
    {
        Context.Dispose();
    }
}

