using HotelManagement.DAL.Repositories;
using HotelManagement.MapperProfiles;
using HotelManagement.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace HotelManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("sk")
                };

                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedUICultures = supportedCultures;
            });

            builder.Services.AddDbContext<HotelManagement.DAL.HotelManagementDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<HotelManagement.Models.ApplicationUser, Microsoft.AspNetCore.Identity.IdentityRole<Guid>>()
                .AddEntityFrameworkStores<HotelManagement.DAL.HotelManagementDbContext>();
			builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			builder.Services.AddScoped<BookingCartService>();
			builder.Services.AddSession();

            builder.Services.AddAutoMapper(typeof(FoodOrderMapperProfile).Assembly);

			AddRepositories(builder.Services);

            var app = builder.Build();

            app.UseRequestLocalization();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");


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
