namespace Projeli.Shared.Application.Messages.Notifications;

public class RemoveNotificationMessage
{
    public required Ulid NotificationId { get; init; }
}