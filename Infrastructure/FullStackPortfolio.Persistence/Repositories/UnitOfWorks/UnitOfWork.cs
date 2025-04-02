using FullStackPortfolio.Domain.Repositories.IAbstracts.IAboutRepositories;
using FullStackPortfolio.Domain.Repositories.IGenerics;
using FullStackPortfolio.Domain.Repositories.IUnitOfWorks;
using FullStackPortfolio.Persistence.Context.Data;
using FullStackPortfolio.Persistence.Repositories.Concretes.AboutRepositories;
using FullStackPortfolio.Persistence.Repositories.Generics;

namespace FullStackPortfolio.Persistence.Repositories.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    protected readonly AppDbContext _context;
    private readonly Dictionary<Type, object> _repositories = new(); // singleton pattern

    public IAboutReadRepository GetAboutReadRepository => GetOrCreateRepository<IAboutReadRepository, AboutReadRepository>();

    public IAboutWriteRepository GetAboutWriteRepository => GetOrCreateRepository<IAboutWriteRepository, AboutWriteRepository>();

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    private TRepo GetOrCreateRepository<TInterface, TRepo>() where TRepo : class, TInterface
    {
        if (!_repositories.TryGetValue(typeof(TInterface), out var repo))
        {
            repo = Activator.CreateInstance(typeof(TRepo), _context);
            _repositories[typeof(TInterface)] = repo;
        }
        return (TRepo)repo;
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        return _context.DisposeAsync();
    }

    public async Task<int> SaveAsync()
    {
        try
        {
            return await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Veritabanı kaydetme hatası: {ex.Message}");
            return -1;
        }
    }

    IGenericReadRepository<T> IUnitOfWork.GetGenericReadRepository<T>()
    {
        return GetOrCreateRepository<IGenericReadRepository<T>, GenericReadRepository<T>>();
    }

    IGenericWriteRepository<T> IUnitOfWork.GetGenericWriteRepository<T>()
    {
        return GetOrCreateRepository<IGenericWriteRepository<T>, GenericWriteRepository<T>>();
    }
}
