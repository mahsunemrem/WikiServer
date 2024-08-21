using AutoMapper;
using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Domain.AggregateModels.FolderModels;

namespace WikiServer.Api.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Folder,FolderDTO>();
            CreateMap<FolderDTO,Folder>();
        }
    }
}
