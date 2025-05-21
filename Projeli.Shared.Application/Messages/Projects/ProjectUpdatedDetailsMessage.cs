using MassTransit;

namespace Projeli.Shared.Application.Messages.Projects;

[EntityName("ProjectUpdatedDetails")]
public class ProjectUpdatedDetailsMessage
{
    public Ulid ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string ProjectSlug { get; set; }
    public string UserId { get; set; }
}