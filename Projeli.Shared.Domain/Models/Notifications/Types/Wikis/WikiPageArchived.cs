using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents a notification that a wiki page of a wiki a user is a member of has been archived.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(WikiPageArchived), (int)NotificationType.WikiPageArchived)]
public class WikiPageArchived : WikiPageNotificationBody
{
    /// <summary>
    /// The user who archived the wiki page.
    /// </summary>
    public required string PerformerId { get; set; }
}