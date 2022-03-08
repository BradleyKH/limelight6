using System.ComponentModel.DataAnnotations;

namespace Limelight6.Auth.Models
{
    public class ConfirmUserRequest
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(128)]
        public string Token { get; set; }
    }
}
