using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents a notification body for when a wiki a user is a member of is archived.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(WikiArchived), (int)NotificationType.WikiArchived)]
public class WikiArchived : WikiNotificationBody
{
    /// <summary>
    /// The user who archived the wiki.
    /// </summary>
    public required string PerformerId { get; set; }
}