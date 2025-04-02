using FullStackPortfolio.Domain.Repositories.IAbstracts.IAboutRepositories;
using FullStackPortfolio.Persistence.Repositories.Concretes.AboutRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace FullStackPortfolio.Persistence.Extensions;

public static class RepositoriesExtensions
{
    public static void AddRepositoriesExtension(this IServiceCollection services)
    {
        services.AddScoped<IAboutReadRepository, AboutReadRepository>();
        services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();
    }
}
