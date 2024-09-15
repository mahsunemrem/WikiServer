using AutoMapper;
using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Application.Interfaces.Folders;
using WikiServer.Domain.AggregateModels.FolderModels;

namespace WikiServer.Api.ModelServices
{
    public class FolderModelService : IFolderModelService
    {
        private readonly IFolderService _service;
        private readonly IMapper _mapper;
        public FolderModelService(IFolderService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task AddAsync(FolderDTO folderDTO)
        {
 
            var folder = _mapper.Map<Folder>(folderDTO);


            await _service.AddAsync(folder);
        }

        public async Task<IEnumerable<FolderDTO>> GetAllFolder()
        {
            var folders = await _service.GetAll();

            
            var folderDTOs = _mapper.Map<IEnumerable<FolderDTO>>(folders);

       
            return folderDTOs;
        }

        public async Task<FolderDTO> GetById(int id)
        {
           var folder = await _service.GetByIdAsync(id);
            var folderDto = _mapper.Map<FolderDTO>(folder);
            return folderDto;
        }
    }
}

