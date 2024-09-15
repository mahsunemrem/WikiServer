using AutoMapper;
using System.Linq.Expressions;
using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Dtos.FileDTO;
using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Application.Interfaces.Files;
using WikiServer.Application.Interfaces.Folders;
using WikiServer.Domain.AggregateModels.FileModels;
using WikiServer.Domain.AggregateModels.FolderModels;

namespace WikiServer.Api.ModelServices
{
    public class FileModelService : IFileModelService
    {
        private readonly IFileService _service;
        private readonly IMapper _mapper;
        public FileModelService(IFileService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task AddAsync(FileDTO fileDTO)
        {

            var file = _mapper.Map<Domain.AggregateModels.FileModels.File>(fileDTO);


            await _service.AddAsync(file);


        }

        public async Task Delete(int id)
        {       
                var file = await _service.GetByIdAsync(id);
                if (file != null)
                {
                    await _service.DeleteAsync(file);
                }          
        }

        public async Task<FileDTO> FirstOrDefault(Expression<Func<FileDTO, bool>> where, bool noTracking = false)
        {
           var fileExpression = _mapper.Map<Expression<Func<Domain.AggregateModels.FileModels.File,bool>>>(where);

            var file = await _service.FirstOrDefault(fileExpression,noTracking);

            return _mapper.Map<FileDTO>(file);
        }

        public async Task<IEnumerable<FileDTO>> GetByFolderId(int folderId)
        {
            var files = await _service.GetByFolderId(folderId);
            var fileDTOs = _mapper.Map<IEnumerable<FileDTO>>(files);
            return fileDTOs;

        }

        public async Task<FileDTO> GetById(int id)
        {
            var file = await _service.GetByIdAsync(id);
            var fileDto = _mapper.Map<FileDTO>(file);
            return fileDto;
        }

        public async Task Update(FileDTO fileDTO)
        {
            var file = _mapper.Map<Domain.AggregateModels.FileModels.File>(fileDTO);
           await  _service.Update(file);
        }
    }
}

