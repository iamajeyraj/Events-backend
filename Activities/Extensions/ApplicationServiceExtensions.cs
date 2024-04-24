using Activities.Application;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Activities.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddRazorPages();
            services.AddDbContext<ApplicationDbContext>(Options =>
            {
                Options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddCors(options =>
            {
                options.AddPolicy("Cors-Policy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5000");
                });
            });

            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ActivityList.Handler).Assembly));
            return services;
        }
    }
}