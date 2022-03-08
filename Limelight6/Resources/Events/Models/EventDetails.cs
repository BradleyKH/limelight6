namespace Limelight6.Resources.Events.Models
{
    [GraphQLDescription("Details for an event, including steps, fees, header, and other settings.")]
    public class EventDetails
    {
        public IEnumerable<EventStep> Steps { get; set; } = new List<EventStep>();
        public IEnumerable<EventFee> Fees { get; set; } = new List<EventFee>();
        public object? JurorSubmissionView { get; set; }
        public EventHeader? Header { get; set; }
        public EventSettings? Settings { get; set; }
    }
}
