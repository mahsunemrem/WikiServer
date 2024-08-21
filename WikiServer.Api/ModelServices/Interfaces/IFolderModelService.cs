using WikiServer.Application.Dtos.FolderDTO;

namespace WikiServer.Api.ModelServices.Interfaces
{
    public interface IFolderModelService
    {
        void AddOrUpdate(FolderDTO folderDTO);
    }
}
