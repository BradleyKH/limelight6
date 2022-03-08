using Limelight6.Resources.Registrations;

namespace Limelight6.GraphQL.Models
{
    public class RegistrationType : ObjectType<Registration>
    {
        protected override void Configure(IObjectTypeDescriptor<Registration> descriptor)
        {
            descriptor.Description("A record of a user's registration for an event.");
        }
    }
}
