using MassTransit;

namespace Projeli.Shared.Application.Messages.Projects;

[EntityName("ProjectUpdatedOwnership")]
public class ProjectUpdatedOwnershipMessage
{
    public Ulid ProjectId { get; set; }
    public string FromUserId { get; init; }
    public string ToUserId { get; init; }
}