using WikiServer.Domain.SeedWorks;

namespace WikiServer.Infrastructure.Domain
{
    public class Result : IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }

        public Result()
        {
            Errors = new List<string>();
        }

        public static Result SuccessResult(string message = "")
        {
            return new Result { Success = true, Message = message };
        }

        public static Result FailureResult(string message, List<string> errors = null)
        {
            return new Result { Success = false, Message = message, Errors = errors ?? new List<string>() };
        }
    }
    public class Result<T> : Result
    {
        public T Data { get; set; }

        public static Result<T> SuccessResult(T data, string message = "")
        {
            return new Result<T> { Success = true, Data = data, Message = message };
        }

        public static Result<T> FailureResult(string message, List<string> errors = null)
        {
            return new Result<T> { Success = false, Message = message, Errors = errors ?? new List<string>() };
        }
    }
}