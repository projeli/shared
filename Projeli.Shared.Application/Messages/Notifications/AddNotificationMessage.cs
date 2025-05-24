using Projeli.Shared.Domain.Models.Notifications;

namespace Projeli.Shared.Application.Messages.Notifications;

public class AddNotificationMessage
{
    public required NotificationMessage Notification { get; init; }
}