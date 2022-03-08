using Limelight6.Database;
using Limelight6.Resources.Evaluations;
using Limelight6.Resources.Events.Models;
using Limelight6.Resources.Forms;
using Limelight6.Resources.Registrations;
using Limelight6.Resources.Submissions;

namespace Limelight6.Schema.Queries
{
    public class Query
    {
        [GraphQLDescription("Get a list of all public events.")]
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        public IQueryable<Event> GetEvents([ScopedService] AppDbContext context)
        {
            return context.Events.Where(e => e.IsPublic);
        }

        [UseDbContext(typeof(AppDbContext))]
        [GraphQLDescription("Get registrations for an event.")]
        [UseProjection]
        [UseSorting]
        public IQueryable<Registration> GetRegistrations([ScopedService] AppDbContext context, int eventId)
        {
            return context.Registrations.Where(r => r.EventId == eventId);
        }

        [UseDbContext(typeof(AppDbContext))]
        [GraphQLDescription("Get submissions for an event.")]
        [UseProjection]
        [UseSorting]
        public IQueryable<Submission> GetSubmissions([ScopedService] AppDbContext context, int eventId)
        {
            return context.Submissions.Where(s => s.EventId == eventId);
        }

        [UseDbContext(typeof(AppDbContext))]
        [GraphQLDescription("Get forms for an event.")]
        [UseProjection]
        public IQueryable<Form> GetForms([ScopedService] AppDbContext context, int eventId)
        {
            return context.Forms.Where(f => f.EventId == eventId);
        }

        [UseDbContext(typeof(AppDbContext))]
        [GraphQLDescription("Get evaluations for a user.")]
        [UseProjection]
        public IQueryable<Evaluation> GetEvaluationsForUser([ScopedService] AppDbContext context, int userId)
        {
            return context.Evaluations.Where(e => e.JurorId == userId);
        }

        [UseDbContext(typeof(AppDbContext))]
        [GraphQLDescription("Get evaluations for an event.")]
        [UseProjection]
        public IQueryable<Evaluation> GetEvaluationsForEvent([ScopedService] AppDbContext context, int eventId)
        {
            return context.Evaluations.Where(e => e.Submission!.EventId == eventId);
        }
    }
}
