using FullStackPortfolio.Domain.Repositories.IGenerics;
using FullStackPortfolio.Persistence.Repositories.Generics;
using Microsoft.Extensions.DependencyInjection;

namespace FullStackPortfolio.Persistence.Extensions;

public static class GenericExtensions
{
    public static void AddGenericPatternExtension(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericReadRepository<>), typeof(GenericReadRepository<>));
        services.AddScoped(typeof(IGenericWriteRepository<>), typeof(GenericWriteRepository<>));
    }
}
