using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

/// <summary>
/// Represents a notification body for when a wiki a user was a member of is deleted.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(WikiDeleted), (int)NotificationType.WikiDeleted)]
public class WikiDeleted : WikiNotificationBody
{
    /// <summary>
    /// The user who deleted the wiki.
    /// </summary>
    public required string PerformerId { get; set; }
    
    /// <summary>
    /// The name of the wiki that was deleted.
    /// </summary>
    public required string WikiName { get; set; }
}