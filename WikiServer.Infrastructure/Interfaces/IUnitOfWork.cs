using WikiServer.Infrastructure.Interfaces;

namespace WikiServer.Domain.SeedWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IEFRepository<T> Repository<T>() where T : class;

        int Save();
        Task<int> SaveAsync();
        Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
