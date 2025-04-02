using FullStackPortfolio.Domain.Entities.IBase;
using FullStackPortfolio.Domain.Repositories.IAbstracts.IAboutRepositories;
using FullStackPortfolio.Domain.Repositories.IGenerics;

namespace FullStackPortfolio.Domain.Repositories.IUnitOfWorks;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    IGenericReadRepository<T> GetGenericReadRepository<T>() where T : class, IBaseEntity, new();
    IGenericWriteRepository<T> GetGenericWriteRepository<T>() where T : class, IBaseEntity, new();
    Task<int> SaveAsync();
    IAboutReadRepository GetAboutReadRepository { get; }
    IAboutWriteRepository GetAboutWriteRepository { get; }
}
