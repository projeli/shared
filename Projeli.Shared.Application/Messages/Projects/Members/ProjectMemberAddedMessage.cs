using MassTransit;

namespace Projeli.Shared.Application.Messages.Projects.Members;

[EntityName("ProjectMemberAdded")]
public class ProjectMemberAddedMessage
{
    public Ulid ProjectId { get; set; }
    public string UserId { get; set; }
    public string PerformingUserId { get; set; }
}