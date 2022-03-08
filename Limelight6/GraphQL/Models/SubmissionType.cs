using Limelight6.Resources.Submissions;

namespace Limelight6.GraphQL.Models
{
    public class SubmissionType : ObjectType<Submission>
    {
        protected override void Configure(IObjectTypeDescriptor<Submission> descriptor)
        {
            descriptor.Description("A user's submission for a event.");
        }
    }
}
