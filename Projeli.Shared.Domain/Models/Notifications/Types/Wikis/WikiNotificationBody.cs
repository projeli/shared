using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents an abstract notification body for wiki-related notifications.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
public abstract class WikiNotificationBody : NotificationBody
{
    /// <summary>
    /// The ID of the wiki related to the notification.
    /// </summary>
    public required Ulid WikiId { get; set; }
}