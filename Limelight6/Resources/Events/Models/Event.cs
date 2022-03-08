using Limelight6.Resources.Forms;
using Limelight6.Resources.Payments;
using Limelight6.Resources.Registrations;
using Limelight6.Resources.Submissions;
using Limelight6.Resources.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Limelight6.Resources.Events.Models
{
    [Table("Events")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string? Key { get; set; }

        public int CreatorId { get; set; }

        [ForeignKey(nameof(CreatorId))]
        public virtual User? User { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public bool IsPublic { get; set; }

        public string? DetailsJson { get; set; }
        [NotMapped]
        public EventDetails? Details { get; set; }

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public virtual ICollection<Form> Forms { get; set; } = new List<Form>();
        public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
        public virtual ICollection<Submission> Submissions { get; set; } = new List<Submission>();
    }
}
