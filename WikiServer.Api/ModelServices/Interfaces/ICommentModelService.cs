using System.Linq.Expressions;
using WikiServer.Application.Dtos.CommentDTO;

namespace WikiServer.Api.ModelServices.Interfaces
{
    public interface ICommentModelService
    {
        Task AddAsync(CommentDTO commentDTO);
        Task<CommentDTO> GetById(int id);
        Task<IEnumerable<CommentDTO>> GetAll();
        Task Delete(int id);
        Task Update(CommentDTO commentDTO);
        Task<CommentDTO> FirstOrDefault(Expression<Func<CommentDTO, bool>> where, bool noTracking = false);
    }
}
