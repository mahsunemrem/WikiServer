using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Application.Interfaces.Folders;

namespace WikiServer.Api.ModelServices
{
    public class FolderModelService : IFolderModelService
    {
        private IFolderService _service;

        public FolderModelService(IFolderService service)
        {
            _service = service;
        }

        public void AddOrUpdate(FolderDTO folderDTO)
        {
            //folderDTO to folder
            // auto mapper kullan!
            var folder = folderDTO.toFolder();

            _service.AddOrUpdate(folder);
        }
    }
}
