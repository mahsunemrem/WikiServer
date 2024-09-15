using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WikiServer.Application.Interfaces.Comment;
using WikiServer.Domain.AggregateModels.CommentModels;
using WikiServer.Domain.SeedWorks;

namespace WikiServer.Application.Services.Comment
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Domain.AggregateModels.CommentModels.Comment entity)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.CommentModels.Comment>();

          
                repo.Insert(entity);
         
       
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(Domain.AggregateModels.CommentModels.Comment entity)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.CommentModels.Comment>();


            var file = await repo.GetById(entity.Id);

            if (file != null)
            {

                await repo.Delete(file);

                await _unitOfWork.SaveAsync();
            }
            else
            {

                throw new ArgumentException("Yorum bulunamadı");
            }
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public Task<IEnumerable<Domain.AggregateModels.CommentModels.Comment>> FindAsync(Expression<Func<Domain.AggregateModels.CommentModels.Comment, bool>> predicate, bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.AggregateModels.CommentModels.Comment> FirstOrDefault(Expression<Func<Domain.AggregateModels.CommentModels.Comment, bool>> where, bool noTracking = false)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.CommentModels.Comment>(); 

            var comment = await repo.FirstOrDefault(where, noTracking);

            return comment;
        }

        public async Task<IEnumerable<Domain.AggregateModels.CommentModels.Comment>> GetAll()
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.CommentModels.Comment>();

            var comment = repo.GetAll;

            return await Task.FromResult(comment);
        }

        public async Task<Domain.AggregateModels.CommentModels.Comment> GetByIdAsync(params object[] id)
        {
            var repo = _unitOfWork.Repository<Domain.AggregateModels.CommentModels.Comment>();
            var comment = await repo.GetById(id);
            return comment;
        }

        public Task Update(Domain.AggregateModels.CommentModels.Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
