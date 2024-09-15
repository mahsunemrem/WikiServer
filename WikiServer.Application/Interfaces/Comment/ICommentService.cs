using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiServer.Domain.AggregateModels.CommentModels;


namespace WikiServer.Application.Interfaces.Comment
{
    public interface ICommentService : IBusinessService<Domain.AggregateModels.CommentModels.Comment>
    {
    }
}
