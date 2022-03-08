namespace Limelight6.Resources.Events.Models
{
    public class EventFee
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
    }
}
