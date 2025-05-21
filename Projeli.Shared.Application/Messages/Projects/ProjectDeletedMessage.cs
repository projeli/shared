using MassTransit;

namespace Projeli.Shared.Application.Messages.Projects;

[EntityName("ProjectDeleted")]
public class ProjectDeletedMessage
{
    public Ulid ProjectId { get; set; }
    public string UserId { get; set; }
}