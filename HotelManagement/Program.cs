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

namespace HotelManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(
                    "Logging/all-log-.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Logger(l => l
                    .Filter.ByIncludingOnly(logEvent =>
                        logEvent.Properties.ContainsKey("SourceContext") &&
                        logEvent.Properties["SourceContext"].ToString().Contains("AuditLogger"))
                    .WriteTo.File(
                        "Logging/user-actions-.txt", rollingInterval: RollingInterval.Day))
                .CreateLogger();

            builder.Host.UseSerilog();

            builder.Services.AddSingleton<AuditLogger>();

            builder.Services.AddControllersWithViews()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedUICultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("sk")
                };

                var defaultCulture = new RequestCulture(
                    culture: "en-US",       // parsing (decimal separator for price)
                    uiCulture: "en"         // UI translations
                );

                options.DefaultRequestCulture = defaultCulture;
                options.SupportedCultures = new[] { new CultureInfo("en-US") }; //parsing
                options.SupportedUICultures = supportedUICultures;

                options.RequestCultureProviders.Insert(0, new CookieRequestCultureProvider());
            });

            builder.Services.AddDbContext<HotelManagement.DAL.HotelManagementDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<HotelManagement.Models.ApplicationUser, Microsoft.AspNetCore.Identity.IdentityRole<Guid>>()
                .AddEntityFrameworkStores<HotelManagement.DAL.HotelManagementDbContext>()
                .AddDefaultTokenProviders();
			builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			builder.Services.AddScoped<BookingCartService>();
			builder.Services.AddSession();

            builder.Services.AddAutoMapper(typeof(FoodOrderMapperProfile).Assembly);

			AddRepositories(builder.Services);

            var app = builder.Build();

            var localizationOptions = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
            app.UseRequestLocalization(localizationOptions);

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


            // Seed Room Type Images if not seeded yet
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<HotelManagement.DAL.HotelManagementDbContext>();
                RoomTypeImageSeeder.SeedImagesAsync(dbContext).GetAwaiter().GetResult();
            }

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
            services.AddScoped<ApplicationUserRepository, ApplicationUserRepository>();
        }
    }
}
