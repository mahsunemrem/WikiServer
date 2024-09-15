using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WikiServer.Application.Interfaces;
using WikiServer.Application.Interfaces.Files;
using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Domain.SeedWorks;

namespace WikiServer.Application.Services.Files
{
    public class FileService : IFileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Domain.AggregateModels.FileModels.File entity)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.FileModels.File>();


                repo.Insert(entity);

           

            await _unitOfWork.SaveAsync();

        }

        public async Task DeleteAsync(Domain.AggregateModels.FileModels.File entity)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.FileModels.File>();

         
            var file = await repo.GetById(entity.Id);

            if (file != null)
            {
                
              await  repo.Delete(file);
             
                await _unitOfWork.SaveAsync();
            }
            else
            {
               
                throw new ArgumentException("Dosya bulunamadı");
            }
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public Task<IEnumerable<Domain.AggregateModels.FileModels.File>> FindAsync(Expression<Func<Domain.AggregateModels.FileModels.File, bool>> predicate, bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.AggregateModels.FileModels.File> FirstOrDefault(Expression<Func<Domain.AggregateModels.FileModels.File, bool>> where, bool noTracking = false)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.FileModels.File>();

            var file =  repo.FirstOrDefault(where, noTracking);

            return file;
        }

      
        public async Task<IEnumerable<Domain.AggregateModels.FileModels.File>> GetAll()
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.FileModels.File>();

            var files = repo.GetAll;

            return await Task.FromResult(files);
        }

        /*
         * ModelServiceKatmanı -> pascal case
         * model_service_katmanı -> snake case
         * modelServiceKatmanı -> camel case
         * */
        public async Task<List<Domain.AggregateModels.FileModels.File>> GetByFolderId(int folderId)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.FileModels.File>();

            var files = repo.GetAllNoTracking
                .Where(x => x.FolderID == folderId)
                .ToList();

            return await Task.FromResult(files);
        }

        public async Task<Domain.AggregateModels.FileModels.File> GetByIdAsync(params object[] id)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.FileModels.File>();
            var file = await repo.GetById(id);
            return file;
        }

        public async Task Update(Domain.AggregateModels.FileModels.File entity)
        {
            var repo = _unitOfWork
                .Repository<Domain.AggregateModels.FileModels.File>();
            
            repo.Update(entity);

           await  _unitOfWork.SaveAsync();
        }
    }
}
