using Limelight6.Resources.Evaluations;
using Limelight6.Resources.Events.Models;
using Limelight6.Resources.Forms;
using Limelight6.Resources.Supplements;
using Limelight6.Resources.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Limelight6.Resources.Submissions
{
    [Table("Submissions")]
    public class Submission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        [ForeignKey(nameof(EventId))]
        public virtual Event? Event { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }

        [Required]
        public int FormId { get; set; }
        [ForeignKey(nameof(FormId))]
        public virtual Form? Form { get; set; }

        public string? Name { get; set; }

        [MaxLength(50)]
        public string? Category { get; set; }

        public DateTime? DateCreatedUtc { get; set; }

        public string? Code { get; set; }

        public string? DetailsJson { get; set; }
        [NotMapped]
        public object? Details { get; set; }

        public virtual ICollection<Supplement> Supplements { get; set; } = new List<Supplement>();
        public virtual ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}
