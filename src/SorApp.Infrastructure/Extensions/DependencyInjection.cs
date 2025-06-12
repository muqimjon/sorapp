namespace SorApp.Infrastructure.Extensions;

using Amazon.S3;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SorApp.Infrastructure.Data;
using SorApp.Infrastructure.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<AppDbContext>(opt =>
            opt.UseNpgsql(config.GetConnectionString("DefaultConnection")));

        services.AddAuthentication(options =>
        {
            options.DefaultScheme = IdentityConstants.ApplicationScheme;
        }).AddCookie(IdentityConstants.ApplicationScheme);

        services.AddDefaultAWSOptions(config.GetAWSOptions());
        services.AddAWSService<IAmazonS3>();

        services.AddScoped<IStorageService, StorageService>();

        return services;
    }
}
