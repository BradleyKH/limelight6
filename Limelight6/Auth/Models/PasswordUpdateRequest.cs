using System.ComponentModel.DataAnnotations;

namespace Limelight6.Auth.Models
{
    public class PasswordUpdateRequest
    {
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
    }
}
