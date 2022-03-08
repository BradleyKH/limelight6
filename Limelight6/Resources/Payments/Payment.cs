using Limelight6.Resources.Events.Models;
using Limelight6.Resources.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Limelight6.Resources.Payments
{
    [Table("Payments")]
    public class Payment
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
        public decimal Amount { get; set; }

        [Required]
        public DateTime? DateUtc { get; set; }
    }
}
