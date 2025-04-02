using FullStackPortfolio.Domain.Entities;
using FullStackPortfolio.Domain.Repositories.IAbstracts.IAboutRepositories;
using FullStackPortfolio.Persistence.Context.Data;
using FullStackPortfolio.Persistence.Repositories.Generics;
using Microsoft.EntityFrameworkCore;

namespace FullStackPortfolio.Persistence.Repositories.Concretes.AboutRepositories;

public class AboutReadRepository : GenericReadRepository<About>, IAboutReadRepository
{
    public AboutReadRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<About> GetAboutsByIdAsync(Guid id, bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (!trackChanges) query.AsNoTracking();

        return await query.FirstOrDefaultAsync(q => q.BaseId == id, cancellationToken);
    }

    public async Task<IList<About>> GetAllAboutsAsync(bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (!trackChanges) query.AsNoTracking();

        return await query.ToListAsync(cancellationToken);
    }
}
