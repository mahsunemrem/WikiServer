using AutoMapper;
using System.Linq.Expressions;
using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Dtos.CommentDTO;
using WikiServer.Application.Interfaces.Comment;
using WikiServer.Domain.AggregateModels.CommentModels;

namespace WikiServer.Api.ModelServices
{
    public class CommentModelService : ICommentModelService
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentModelService(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public async Task AddAsync(CommentDTO commentDTO)
        {
            var comment = _mapper.Map<Comment>(commentDTO);
            await _commentService.AddAsync(comment);
         
        }

        public async Task Delete(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            await _commentService.DeleteAsync(comment);
        }

        public async Task<CommentDTO> FirstOrDefault(Expression<Func<CommentDTO, bool>> where, bool noTracking = false)
        {

            var commentExpression = _mapper.Map<Expression<Func<Comment, bool>>>(where);

            var comment = await _commentService.FirstOrDefault(commentExpression, noTracking);

            return _mapper.Map<CommentDTO>(comment);
        }

        public async Task<IEnumerable<CommentDTO>> GetAll()
        {
            var comment = await _commentService.GetAll();
            var commentDtOs = _mapper.Map<IEnumerable<CommentDTO>>(comment);
            return commentDtOs;

        }

        public async Task<CommentDTO> GetById(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            var commentDto = _mapper.Map<CommentDTO>(comment);
            return commentDto;
        }

        public Task Update(CommentDTO commentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
