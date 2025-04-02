using FullStackPortfolio.Domain.Repositories.IUnitOfWorks;
using FullStackPortfolio.Persistence.Repositories.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace FullStackPortfolio.Persistence.Extensions;

public static class UoWExtensions
{
    public static void AddUnitOfWorkExtension(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
