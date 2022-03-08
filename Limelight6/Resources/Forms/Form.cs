using Limelight6.Resources.Events.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Limelight6.Resources.Forms
{
    [Table("Forms")]
    public class Form
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        [ForeignKey(nameof(EventId))]
        public virtual Event? Event { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Type { get; set; }

        [MaxLength(50)]
        public string? NameField { get; set; }

        public string? RowsJson { get; set; }
        //[NotMapped]
        //public IEnumerable<List<object>> Rows { get; set; } = new List<List<object>>();
    }
}
