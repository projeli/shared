using MassTransit;

namespace Projeli.Shared.Application.Messages.Projects.Members;

[EntityName("ProjectMemberRemoved")]
public class ProjectMemberRemovedMessage
{
    public Ulid ProjectId { get; set; }
    public string UserId { get; set; }
    public string PerformingUserId { get; set; }
}