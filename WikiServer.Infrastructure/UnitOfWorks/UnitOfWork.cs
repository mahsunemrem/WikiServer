using WikiServer.Domain.SeedWorks;
using WikiServer.Infrastructure.Database;
using WikiServer.Infrastructure.Interfaces;
using WikiServer.Infrastructure.Repositories;

namespace WikiServer.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext Context { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEFRepository<T> Repository<T>() where T : class
        {
            var repo = new BaseRepository<T>(Context);

            return repo;
        }

        public int Save()
        {
            return Context.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return Context.SaveChangesAsync();
        }

        public Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return Context.SaveChangesAsync(cancellationToken);
        }

        #region Dispose

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            try
            {
                if (!this._disposed)
                {
                    if (disposing)
                    {
                        //_logDbUnitOfWork?.Dispose();
                        Context?.Dispose();
                    }
                }
            }
            catch
            {
                // Ignore.
            }

            this._disposed = true;
        }

        /// <summary>
        /// Disposing
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}