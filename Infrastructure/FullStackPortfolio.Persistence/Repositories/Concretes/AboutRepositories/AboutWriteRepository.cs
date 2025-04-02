using FullStackPortfolio.Domain.Entities;
using FullStackPortfolio.Domain.Repositories.IAbstracts.IAboutRepositories;
using FullStackPortfolio.Persistence.Context.Data;
using FullStackPortfolio.Persistence.Repositories.Generics;

namespace FullStackPortfolio.Persistence.Repositories.Concretes.AboutRepositories;

public class AboutWriteRepository : GenericWriteRepository<About>, IAboutWriteRepository
{
    public AboutWriteRepository(AppDbContext context) : base(context)
    {
    }

    public async Task CreateAbout(About createAbout)
    {
        await _context.Abouts.AddAsync(createAbout);
        await _context.SaveChangesAsync();
    }
}
