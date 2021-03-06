using Limelight6.Resources.Forms;
using Limelight6.Resources.Submissions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Limelight6.Resources.Supplements
{
    [Table("Supplements")]
    public class Supplement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public int SubmissionId { get; set; }
        [ForeignKey(nameof(SubmissionId))]
        public virtual Submission? Submission { get; set; }
        
        [Required]
        public int FormId { get; set; }
        [ForeignKey(nameof(FormId))]
        public virtual Form? Form { get; set; }

        public DateTime? DateCreatedUtc { get; set; }

        public string? DetailsJson { get; set; }
        [NotMapped]
        public object? Details { get; set; }
    }
}
