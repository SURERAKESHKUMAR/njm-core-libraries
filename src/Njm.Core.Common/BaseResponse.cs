namespace Njm.Core.Common;

public class BaseResponse<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }

    public static BaseResponse<T> Ok(T data)
        => new() { Success = true, Data = data };

    public static BaseResponse<T> Fail(string message)
        => new() { Success = false, Message = message };
}
