namespace Limelight6.Utilities
{
    public static class Encryptor
    {
        public static string GenerateToken()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }

        public static string GeneratePasswordHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string attempt, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(attempt, storedHash);
        }
    }
}
