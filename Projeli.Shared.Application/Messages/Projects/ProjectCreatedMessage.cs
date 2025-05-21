using MassTransit;

namespace Projeli.Shared.Application.Messages.Projects;

[EntityName("ProjectCreated")]
public class ProjectCreatedMessage
{
    public Ulid ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string ProjectSlug { get; set; }
    public string UserId { get; set; }
}