namespace Limelight6.Utilities
{
    public static class FileUtils
    {
        public static string GenerateFileName(string fileName)
        {
            var dateString = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            return $"{dateString}-{fileName.Trim().ToLower().Replace(" ", "-")}";
        }

        public static string GetContentType(string fileName)
        {
            return fileName.Split(".").LastOrDefault() switch
            {
                "jpg" or "jpeg" => "image/jpeg",
                "pdf" => "application/pdf",
                "csv" => "text/csv",
                "doc" => "application/msword",
                "docx" => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                "gif" => "image/gif",
                "png" => "image/png",
                "svg" => "image/svg+xml",
                "txt" => "text/plain",
                _ => "application/octet-stream",
            };
        }
    }
}
