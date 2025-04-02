using FullStackPortfolio.Domain.Entities;
using FullStackPortfolio.Domain.Repositories.IGenerics;

namespace FullStackPortfolio.Domain.Repositories.IAbstracts.IAboutRepositories;

public interface IAboutWriteRepository : IGenericWriteRepository<About>
{
    Task CreateAbout(About createAbout);
}
