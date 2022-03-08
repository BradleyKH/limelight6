using Limelight6.Database;
using Limelight6.GraphQL.Models;
using Limelight6.Resources.Events.Models;

namespace Limelight6.GraphQL.Mutations
{
    public class Mutation
    {
        [GraphQLDescription("Create a new event.")]
        [UseDbContext(typeof(AppDbContext))]
        public async Task<Event> AddEvent(EventInput input, [ScopedService] AppDbContext context)
        {
            var @event = new Event
            {
                Name = input.Name,
                Key = input.Key,
                CreatorId = input.CreatorId,
                Description = input.Description,
                IsActive = input.IsActive,
                IsPublic = input.IsPublic
            };

            context.Events.Add(@event);
            await context.SaveChangesAsync();

            return @event;
        }
    }
}
