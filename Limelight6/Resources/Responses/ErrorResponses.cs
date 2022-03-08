namespace Limelight6.Resources.Responses
{
    public static class ErrorResponses
    {
        public static ErrorResponse NoAccount { get; set; } = new ErrorResponse(1, "Account does not exist.");
        public static ErrorResponse Password { get; set; } = new ErrorResponse(2, "Invalid password. Try again!");
        public static ErrorResponse DuplicateEmail { get; set; } = new ErrorResponse(3, "An account with that email address already exists.");
        public static ErrorResponse Session { get; set; } = new ErrorResponse(4, "The user is not logged in.");
        public static ErrorResponse Concurrency { get; set; } = new ErrorResponse(5, "That record has already been updated. Try again!");
        public static ErrorResponse InvalidToken { get; set; } = new ErrorResponse(6, "Invalid token.");
        public static ErrorResponse ExpiredToken { get; set; } = new ErrorResponse(7, "Expired token.");
        public static ErrorResponse LockedAccount { get; set; } = new ErrorResponse(8, "Account is locked.");
        public static ErrorResponse Unconfirmed { get; set; } = new ErrorResponse(9, "Email address is not confirmed.");

        public static ErrorResponse Unauthorized { get; set; } = new ErrorResponse(401, "You are not authorized to do that.");
        public static ErrorResponse NotFound { get; set; } = new ErrorResponse(404, "Record not found.");
    }
}
