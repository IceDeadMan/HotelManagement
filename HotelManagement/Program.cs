using HotelManagement.DAL.Repositories;
using HotelManagement.MapperProfiles;
using HotelManagement.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using Serilog;
using HotelManagement.Logging;
using Microsoft.AspNetCore.Identity;
using HotelManagement.DAL;
using HotelManagement.Models;

namespace HotelManagement
{
    public class Program
    {
        // Main entry point for the application configuration and initialization
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureLogging(builder);
            ConfigureServices(builder);
            AddRepositories(builder);

            var app = builder.Build();

            ConfigureLocalization(app);
            ConfigureMiddleware(app);
            SeedDatabaseImages(app);

            app.Run();
        }

        // Configure Serilog for structured logging and log files path
        private static void ConfigureLogging(WebApplicationBuilder builder)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("Logging/LogFiles/all-log-.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Logger(l => l
                    .Filter.ByIncludingOnly(e =>
                        e.Properties.ContainsKey("SourceContext") &&
                        e.Properties["SourceContext"].ToString().Contains("AuditLogger"))
                    .WriteTo.File("Logging/LogFiles/user-actions-.txt", rollingInterval: RollingInterval.Day))
                .CreateLogger();

            builder.Host.UseSerilog();
        }

        // Configure services for dependency injection
        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddSingleton<AuditLogger>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedUICultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("sk")
                };

                var defaultCulture = new RequestCulture(
                    culture: "en-US",
                    uiCulture: "en"
                );

                options.DefaultRequestCulture = defaultCulture;
                options.SupportedCultures = new[] { new CultureInfo("en-US") };
                options.SupportedUICultures = supportedUICultures;

                options.RequestCultureProviders.Insert(0, new CookieRequestCultureProvider());
            });

            services.AddDbContext<HotelManagementDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<HotelManagementDbContext>()
                .AddDefaultTokenProviders();

            services.AddAutoMapper(typeof(FoodOrderMapperProfile).Assembly);

            services.AddScoped<BookingCartService>();
            services.AddSession();
        }

        // Add repositories to the service collection for data access and manipulation
        public static void AddRepositories(WebApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddScoped<RoomRepository>();
            services.AddScoped<BookingRepository>();
            services.AddScoped<ActivityRecordRepository>();
            services.AddScoped<FoodRepository>();
            services.AddScoped<FoodOrderRepository>();
            services.AddScoped<ReviewRepository>();
            services.AddScoped<EventRepository>();
            services.AddScoped<RoomTypeRepository>();
            services.AddScoped<ApplicationUserRepository>();
        }

        // Configure localization middleware to support multiple languages
        private static void ConfigureLocalization(WebApplication app)
        {
            var localizationOptions = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
            app.UseRequestLocalization(localizationOptions);
        }

        // Configure routes, authorization, error handling, https and others
        private static void ConfigureMiddleware(WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error/500");
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }

        // Seed images separately from the main database seeding, as it requires dynamic serialization
        private static void SeedDatabaseImages(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<HotelManagementDbContext>();
            RoomTypeImageSeeder.SeedImagesAsync(dbContext).GetAwaiter().GetResult();
        }
    }
}
