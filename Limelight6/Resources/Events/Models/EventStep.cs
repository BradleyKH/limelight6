namespace Limelight6.Resources.Events.Models
{
    public class EventStep
    {
        public string Name { get; set; }
        public int? Order { get; set; }
        public string? Type { get; set; }
        public int? MinRequired { get; set; }
        public int? MaxAllowed { get; set; }
        public DateTime? DateStartUtc { get; set; }
        public DateTime? DateEndUtc { get; set; }
        public string? PrerequisiteStep { get; set; }
        public int? FormId { get; set; }
    }
}
