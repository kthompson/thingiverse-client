using System;

namespace ThingiverseClient.Http
{
    public interface IConnection
    {
    }

    public abstract class ApiResponse<T>
    {
        public abstract bool IsSuccess { get; }
    }

    public class ApiSuccessResponse<T> : ApiResponse<T>
    {
        public override bool IsSuccess => true;

        public T Result { get; }

        public ApiSuccessResponse(T result)
        {
            Result = result;
        }
    }

    public class ApiFailureResponse<T> : ApiResponse<T>
    {
        public override bool IsSuccess => false;

        public string Error { get; }

        public ApiFailureResponse(string error)
        {
            Error = error;
        }
    }

    public static class ApiResponseExtensions
    {

        public static TResult Match<T, TResult>(this ApiResponse<T> res, Func<T, TResult> success, Func<string, TResult> failure) =>
            res.IsSuccess
                ? success(((ApiSuccessResponse<T>) res).Result)
                : failure(((ApiFailureResponse<T>) res).Error);

        public static ApiResponse<TResult> Bind<T, TResult>(this ApiResponse<T> res, Func<T, ApiResponse<TResult>> f)
            =>
            res.Match(f, error => new ApiFailureResponse<TResult>(error));
    }
}