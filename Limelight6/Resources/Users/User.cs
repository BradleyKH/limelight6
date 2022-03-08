using Limelight6.Resources.Evaluations;
using Limelight6.Resources.Payments;
using Limelight6.Resources.Permissions;
using Limelight6.Resources.Submissions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Limelight6.Resources.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        [MaxLength(128)]
        public string? PasswordHash { get; set; }

        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        public bool EmailConfirmed { get; set; }
        public int AccessFailedCount { get; set; }
        public bool Locked { get; set; }
        public DateTime? LastLoggedInUtc { get; set; }
        public DateTime? DateCreatedUtc { get; set; }
        
        public string? SettingsJson { get; set; }
        [NotMapped]
        public UserSettings? Settings { get; set; }

        [MaxLength(128)]
        public string? Token { get; set; }
        public DateTime? TokenExpirationUtc { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
        public virtual ICollection<Submission> Submissions { get; set; } = new List<Submission>();
        public virtual ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
