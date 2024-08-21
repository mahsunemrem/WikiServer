using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiServer.Domain.SeedWorks
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
        List<string> Errors { get; }
    }
}
