using FullStackPortfolio.Domain.Entities;
using FullStackPortfolio.Domain.Repositories.IGenerics;

namespace FullStackPortfolio.Domain.Repositories.IAbstracts.IAboutRepositories;

public interface IAboutReadRepository : IGenericReadRepository<About>
{
    Task<IList<About>> GetAllAboutsAsync(bool trackChanges = false, CancellationToken cancellationToken = default);
    Task<About> GetAboutsByIdAsync(Guid id, bool trackChanges = false, CancellationToken cancellationToken = default);
}
