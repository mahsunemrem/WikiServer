using System.Linq.Expressions;
using WikiServer.Application.Dtos.FileDTO;


namespace WikiServer.Api.ModelServices.Interfaces
{
    public interface IFileModelService

    {
        Task AddAsync(FileDTO folderDTO);
        Task<FileDTO> GetById(int id);
        Task<IEnumerable<FileDTO>> GetByFolderId(int folderId);
        Task Delete(int id);
        Task Update(FileDTO fileDTO);
        Task<FileDTO> FirstOrDefault(Expression<Func<FileDTO, bool>> where, bool noTracking = false);

    }
}
