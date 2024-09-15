using System.Linq.Expressions;
using WikiServer.Application.Interfaces;
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

        public async Task AddAsync(Folder entity)
        {
            var repo = _unitOfWork.Repository<Folder>();

           

                repo.Insert(entity);
          

     
    

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

        public Task DeleteAsync(Folder entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
           _unitOfWork.Dispose();
        }

        public Task<IEnumerable<Folder>> FindAsync(Expression<Func<Folder, bool>> predicate, bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Folder> FirstOrDefault(Expression<Func<Folder, bool>> where, bool noTracking = false)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Folder>> GetAll()
        {
            var repo = _unitOfWork.Repository<Folder>();
         
            var folders = repo.GetAll; 

            return await Task.FromResult(folders);
        }

        public async Task<Folder> GetByIdAsync(params object[] id)
        {
            var repo = _unitOfWork.Repository<Folder>();
            var folders = await repo.GetById(id);
            return folders;
        }

        public Task Update(Folder entity)
        {
            throw new NotImplementedException();
        }
    }
}
