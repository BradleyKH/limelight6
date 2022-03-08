using Limelight6.Database;
using Limelight6.Resources.Evaluations;
using Limelight6.Resources.Submissions;

namespace Limelight6.GraphQL.Models
{
    public class EvaluationType : ObjectType<Evaluation>
    {
        protected override void Configure(IObjectTypeDescriptor<Evaluation> descriptor)
        {
            descriptor.Description("A juror's evaluation of a submission.");

            descriptor
                .Field(e => e.Submission)
                .ResolveWith<Resolvers>(x => x.GetSubmission(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("The submission being evaluated");
        }

        private class Resolvers
        {
            public Submission GetSubmission([Parent] Evaluation evaluation, [ScopedService] AppDbContext context)
            {
                return context.Submissions.FirstOrDefault(s => s.Id == evaluation.SubmissionId);
            }
        }

    }
}
