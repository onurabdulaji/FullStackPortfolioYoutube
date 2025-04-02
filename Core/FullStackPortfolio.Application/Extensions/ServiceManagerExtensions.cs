using FullStackPortfolio.Application.ManagementServices.AboutServices;
using FullStackPortfolio.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FullStackPortfolio.Application.Extensions;

public static class ServiceManagerExtensions
{
    public static void AddServiceAndManagersExtensions(this IServiceCollection services)
    {
        services.AddScoped<IAboutService, AboutService>();
        services.AddScoped<IAboutManagementService, AboutManagementService>();

    }
}
