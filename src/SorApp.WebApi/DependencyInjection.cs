namespace SorApp.WebApi;

using Microsoft.AspNetCore.Identity;
using SorApp.Infrastructure.Identity;
using SorApp.Infrastructure.Persistence;
using SorApp.WebApi.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();

        services.AddSwaggerGen();
        services.AddEndpointsApiExplorer();

        return services;
    }

    public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddIdentity<AppUser, IdentityRole<Guid>>(options =>
        {
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredLength = 2;
        })
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders()
        .AddApiEndpoints();

        services.AddAuthentication()
            .AddBearerToken(IdentityConstants.BearerScheme);

        services.AddAuthorization();

        return services;
    }
}
