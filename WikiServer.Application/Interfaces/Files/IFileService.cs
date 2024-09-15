using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiServer.Application.Interfaces.Files
{
    public interface IFileService : IBusinessService<Domain.AggregateModels.FileModels.File>
    {
        Task<List<Domain.AggregateModels.FileModels.File>> GetByFolderId(int folderId);
    }
}
