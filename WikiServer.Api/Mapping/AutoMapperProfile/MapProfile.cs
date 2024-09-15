using AutoMapper;
using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Domain.AggregateModels.FileModels;
using File = WikiServer.Domain.AggregateModels.FileModels.File;
using WikiServer.Application.Dtos.FileDTO;
using WikiServer.Application.Dtos.CommentDTO;
using WikiServer.Domain.AggregateModels.CommentModels;


namespace WikiServer.Api.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Folder, FolderDTO>();
            CreateMap<FolderDTO, Folder>();

            CreateMap<File, FileDTO>();
            CreateMap<FileDTO,File>();

            CreateMap<Comment,CommentDTO>();
            CreateMap<CommentDTO, Comment>();

        }
    }
}
