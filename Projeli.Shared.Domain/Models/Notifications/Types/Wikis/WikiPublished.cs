using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents a notification body for when a wiki a user is a member of is archived.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(WikiPublished), (int)NotificationType.WikiPublished)]
public class WikiPublished : WikiNotificationBody
{
    /// <summary>
    /// The user who published the wiki.
    /// </summary>
    public required string PerformerId { get; set; }
}