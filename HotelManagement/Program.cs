using HotelManagement.DAL.Repositories;
using HotelManagement.Services;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<HotelManagement.DAL.HotelManagementDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<HotelManagement.Models.ApplicationUser, Microsoft.AspNetCore.Identity.IdentityRole<Guid>>()
                .AddEntityFrameworkStores<HotelManagement.DAL.HotelManagementDbContext>();
			builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			builder.Services.AddScoped<BookingCartService>();
			builder.Services.AddSession();


			AddRepositories(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                // For unhandled exceptions (500 errors)
                app.UseExceptionHandler("/Error/500");

                // For other status codes like 404, 403, etc.
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
			app.UseSession();

			app.UseAuthorization();

            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Users}/{action=Login}/{id?}");


            app.Run();
        }

        public static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<RoomRepository, RoomRepository>();
            services.AddScoped<BookingRepository, BookingRepository>();
            services.AddScoped<ActivityRecordRepository, ActivityRecordRepository>();
            services.AddScoped<FoodRepository, FoodRepository>();
            services.AddScoped<FoodOrderRepository, FoodOrderRepository>();
            services.AddScoped<ReviewRepository, ReviewRepository>();
            services.AddScoped<EventRepository, EventRepository>();
            services.AddScoped<RoomTypeRepository, RoomTypeRepository>();
        }
    }
}
