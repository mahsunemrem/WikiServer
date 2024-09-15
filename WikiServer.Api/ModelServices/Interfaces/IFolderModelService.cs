using WikiServer.Application.Dtos.FolderDTO;

namespace WikiServer.Api.ModelServices.Interfaces
{
    public interface IFolderModelService
    {
        Task AddAsync(FolderDTO folderDTO);
        Task<IEnumerable<FolderDTO>> GetAllFolder();
        Task<FolderDTO> GetById(int id);
    }
}
