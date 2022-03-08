using Limelight6.Database;
using Limelight6.Resources.Events.Models;
using Limelight6.Resources.Forms;
using Limelight6.Resources.Registrations;
using Limelight6.Resources.Submissions;
using System.Text.Json;

namespace Limelight6.GraphQL.Models
{
    public class EventType : ObjectType<Event>
    {
        protected override void Configure(IObjectTypeDescriptor<Event> descriptor)
        {
            descriptor.Description("An event created by a user.");

            descriptor.Field(x => x.DetailsJson).Ignore();

            descriptor
                .Field(x => x.Details)
                .ResolveWith<Resolvers>(x => x.GetEventDetails(default!));

            descriptor
                .Field(x => x.Submissions)
                .ResolveWith<Resolvers>(x => x.GetSubmissions(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("All submissions for a certain event.");

            descriptor
                .Field(x => x.Registrations)
                .ResolveWith<Resolvers>(x => x.GetRegistrations(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("All registrations for a certain event.");

            descriptor
                .Field(x => x.Forms)
                .ResolveWith<Resolvers>(x => x.GetForms(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("All forms for a certain event.");
        }

        private class Resolvers
        {
            public IQueryable<Submission> GetSubmissions([Parent] Event @event, [ScopedService] AppDbContext context)
            {
                return context.Submissions.Where(s => s.EventId == @event.Id);
            }

            public IQueryable<Registration> GetRegistrations([Parent] Event @event, [ScopedService] AppDbContext context)
            {
                return context.Registrations.Where(r => r.EventId == @event.Id);
            }

            public IQueryable<Form> GetForms([Parent] Event @event, [ScopedService] AppDbContext context)
            {
                return context.Forms.Where(f => f.EventId == @event.Id);
            }

            public EventDetails? GetEventDetails([Parent] Event @event)
            {
                if (!string.IsNullOrWhiteSpace(@event.DetailsJson))
                {
                    return JsonSerializer.Deserialize<EventDetails>(@event.DetailsJson);
                }
                return null;
            }
        }
    }
}
