using Microsoft.EntityFrameworkCore;
using WikiServer.Infrastructure.Database;
using WikiServer.Infrastructure.Interfaces;

namespace WikiServer.Infrastructure.Repositories
{
    public class BaseRepository<T> : IEFRepository<T> where T : class
    {
        private DbSet<T> _dbSet;
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll => throw new NotImplementedException();

        protected virtual DbSet<T> DbSet => _dbSet ?? (_dbSet = _context.Set<T>());

        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public void Delete(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> where, bool noTracking = false)
        {
            throw new NotImplementedException();
        }

        public T GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
