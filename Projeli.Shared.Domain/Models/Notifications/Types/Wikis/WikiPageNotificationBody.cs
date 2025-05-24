using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents an abstract notification body for wiki-page-related notifications.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
public abstract class WikiPageNotificationBody : WikiNotificationBody
{
    /// <summary>
    /// The ID of the wiki page related to the notification.
    /// </summary>
    public required Ulid WikiPageId { get; set; }
}