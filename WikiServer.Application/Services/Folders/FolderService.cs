using System.Linq.Expressions;
using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Application.Interfaces;
using WikiServer.Application.Interfaces.Folders;
using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Infrastructure.Interfaces;


namespace WikiServer.Application.Services.Folders
{
    public class FolderService : IFolderService
    {

        private IEFRepository<Folder> _folderRepository;

        public FolderService(IEFRepository<Folder> folderService)
        {
            _folderRepository = folderService;
        }

        public void AddOrUpdate(FolderDTO folderDto)
        {
            if (folderDto == null)
            {
                throw new ArgumentNullException(nameof(folderDto));
            }

            
            var folder = new Folder(folderDto.ParentId, folderDto.Name, folderDto.Description);

            
            if (folder.Id == 0)
            {
                _folderRepository.Insert(folder);
            }
            else
            {
                _folderRepository.Update(folder);
            }
        }


        public void AddOrUpdate(Folder entity)
        {
            if (entity.Id == 0)
            {
                
                _folderRepository.Insert(entity);
            }
            else
            {
                
                _folderRepository.Update(entity);
            }
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
            _folderRepository.Dispose();
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
