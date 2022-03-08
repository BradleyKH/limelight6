namespace Limelight6.GraphQL.Models
{
    public record EventInput(string Name, string Key, int CreatorId,
        string Description, bool IsActive, bool IsPublic);
}
