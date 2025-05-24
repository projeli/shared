using Projeli.Shared.Domain.Models.Notifications;

namespace Projeli.Shared.Application.Messages.Notifications;

public class NotificationMessage
{
    public required string UserId { get; init; }
    public required NotificationType Type { get; init; }
    public required NotificationBody Body { get; init; }
    public required bool IsRead { get; init; }
}