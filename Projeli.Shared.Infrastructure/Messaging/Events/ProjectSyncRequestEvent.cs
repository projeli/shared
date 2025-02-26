using MassTransit;

namespace Projeli.Shared.Infrastructure.Messaging.Events;

[EntityName("ProjectSyncRequest")]
public class ProjectSyncRequestEvent
{
    public Ulid? ProjectId { get; set; }
    public string? ProjectSlug { get; set; }
}