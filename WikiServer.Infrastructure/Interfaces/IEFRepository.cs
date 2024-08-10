using System.Linq.Expressions;
using WikiServer.Domain.SeedWorks;

namespace WikiServer.Infrastructure.Interfaces
{
    public interface IEFRepository<T> : IRepository<T> where T : class
    {
        bool Any(Expression<Func<T, bool>> predicate);

        T FirstOrDefault(Expression<Func<T, bool>> where, bool noTracking = false);
    }
}
