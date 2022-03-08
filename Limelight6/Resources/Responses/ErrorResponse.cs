namespace Limelight6.Resources.Responses
{
    public class ErrorResponse : IResponse
    {
        public int Code { get; set; }
        public string? Message { get; set; }

        public ErrorResponse() { }
        public ErrorResponse(string message)
        {
            Code = 99;
            Message = message;
        }
        public ErrorResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
