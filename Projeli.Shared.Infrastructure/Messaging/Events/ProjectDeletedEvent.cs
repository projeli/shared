using MassTransit;

namespace Projeli.Shared.Infrastructure.Messaging.Events;

[EntityName("ProjectDeleted")]
public class ProjectDeletedEvent
{
    public Ulid ProjectId { get; set; }
}