using Limelight6.Resources.Payments;

namespace Limelight6.GraphQL.Models
{
    public class PaymentType : ObjectType<Payment>
    {
        protected override void Configure(IObjectTypeDescriptor<Payment> descriptor)
        {
            descriptor.Description("A record of a user's payment for a certain event.");
        }
    }
}
