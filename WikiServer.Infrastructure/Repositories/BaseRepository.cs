using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WikiServer.Infrastructure.Database;
using WikiServer.Infrastructure.Interfaces;

namespace WikiServer.Infrastructure.Repositories
{
    public class BaseRepository<T> : IEFRepository<T> where T : class
    {

        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Entity => _context.Set<T>();
        public IEnumerable<T> GetAll => _context.Set<T>().ToList();

        public IQueryable<T> GetAllNoTracking => _context.Set<T>().AsNoTracking();

        //protected virtual DbSet<T> DbSet => _dbSet ?? (_dbSet = _context.Set<T>());

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return true;
        }

        //public async Task Delete(params object[] id)
        //{
        //    var entity = await _context.Set<T>().FindAsync(id);
        //    if (entity == null)
        //    {
        //        throw new KeyNotFoundException("Entity not found.");
        //    }

        //    if (_context.Entry(entity).State == EntityState.Detached)
        //    {
        //        _context.Set<T>().Attach(entity);
        //    }

        //    _context.Set<T>().Remove(entity);
        //    await _context.SaveChangesAsync();
        //}

        public async Task Delete(T entity)
        {
          // _context.Set<T>().Remove(entity); aşağıdaki farklı kullanım tarzı
            Entity.Remove(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> where, bool noTracking = false)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(where);
        }

        public async Task<T> GetById(params object[] id) => await _context.Set<T>().FindAsync(id);

        public async Task Insert(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }


    }
}
