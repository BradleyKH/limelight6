namespace Limelight6.Resources.Events.Models
{
    public class EventSettings
    {
        public bool JurorsCanEditEvals { get; set; }
        public bool JurorsCanSeeSubmissionNames { get; set; }
        public bool HasCategories { get; set; }
        public IEnumerable<string> Categories { get; set; } = new List<string>();
    }
}
