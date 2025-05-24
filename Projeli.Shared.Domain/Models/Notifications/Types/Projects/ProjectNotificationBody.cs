using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Projects;

/// <summary>
/// Represents an abstract notification body for project-related notifications.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
public abstract class ProjectNotificationBody : NotificationBody
{
    /// <summary>
    /// The ID of the project related to the notification.
    /// </summary>
    public required Ulid ProjectId { get; set; }
}