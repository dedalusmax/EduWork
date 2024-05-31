using EduWork.Data;
using EduWork.Domain.Contracts;
using EduWork.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace EduWork.WebAPI.Configuration;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
