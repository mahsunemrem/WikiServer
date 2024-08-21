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

        public IEnumerable<T> GetAll => throw new NotImplementedException();

        //protected virtual DbSet<T> DbSet => _dbSet ?? (_dbSet = _context.Set<T>());

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return true;
        }

        public void Delete(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> where, bool noTracking = false)
        {
            throw new NotImplementedException();
        }

        public T GetById(params object[] id)
        {
            return _context.Set<T>().Find(id);  
        }

        public void Insert(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
