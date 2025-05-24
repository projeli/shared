using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents a notification that a wiki page of a wiki a user is a member of has deleted.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(WikiPageDeleted), (int)NotificationType.WikiPageDeleted)]
public class WikiPageDeleted : WikiPageNotificationBody
{
    /// <summary>
    /// The user who deleted the wiki page.
    /// </summary>
    public required string PerformerId { get; set; }
    
    /// <summary>
    /// The name of the wiki page that was deleted.
    /// </summary>
    public required string PageName { get; set; }
}