namespace Njm.Core.UserInterface
{
    /// <summary>
    /// Standard API Response Model
    /// </summary>
    public class UiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }
 
        public static UiResponse<T> SuccessResponse(T data, string message = "Request successful")
        {
            return new UiResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }
 
        public static UiResponse<T> FailureResponse(List<string> errors, string message = "Request failed")
        {
            return new UiResponse<T>
            {
                Success = false,
                Message = message,
                Errors = errors
            };
        }
    }
}