using System.Linq.Expressions;
using WikiServer.Application.Interfaces.Folders;
using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Domain.SeedWorks;


namespace WikiServer.Application.Services.Folders
{
    public class FolderService : IFolderService
    {

        private IUnitOfWork _unitOfWork;

        public FolderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddOrUpdateAsync(Folder entity)
        {
            var repo = _unitOfWork.Repository<Folder>();

            if (entity.Id == 0)
            {

                repo.Insert(entity);
            }
            else
            {

                repo.Update(entity);
            }

            await _unitOfWork.SaveAsync();
        }

        public void Delete(Folder entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Folder>> FindAsync(Expression<Func<Folder, bool>> predicate, bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Folder> GetByIdAsync(params object[] id)
        {
            throw new NotImplementedException();
        }
    }
}
