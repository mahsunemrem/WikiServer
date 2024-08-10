using System.Linq.Expressions;
using WikiServer.Application.Interfaces.Folders;
using WikiServer.Domain.AggregateModels.FolderModels;
namespace WikiServer.Application.Services.Folders
{
    public class FolderService : IFolderService<Folder>
    {
        public void AddOrUpdate(Folder entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Folder entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Folder> Find(Expression<Func<Folder, bool>> predicate, bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public Folder GetById(params object[] id)
        {
            throw new NotImplementedException();
        }
    }
}
