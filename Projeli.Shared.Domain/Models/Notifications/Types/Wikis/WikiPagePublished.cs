using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents a notification that a wiki page of a wiki a user is a member of has been published.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(WikiPagePublished), (int)NotificationType.WikiPagePublished)]
public class WikiPagePublished : WikiPageNotificationBody
{
    /// <summary>
    /// The user who published the wiki page.
    /// </summary>
    public required string PerformerId { get; set; }
}