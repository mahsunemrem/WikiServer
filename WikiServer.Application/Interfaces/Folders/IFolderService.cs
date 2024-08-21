using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Domain.AggregateModels.FolderModels;

namespace WikiServer.Application.Interfaces.Folders
{
    public interface IFolderService : IBusinessService<Folder> 
    {
        void AddOrUpdate(FolderDTO folder);
    }
}
