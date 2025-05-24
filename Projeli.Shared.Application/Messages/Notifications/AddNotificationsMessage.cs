using Projeli.Shared.Domain.Models.Notifications;

namespace Projeli.Shared.Application.Messages.Notifications;

public class AddNotificationsMessage
{
    public required List<NotificationMessage> Notifications { get; init; }
}