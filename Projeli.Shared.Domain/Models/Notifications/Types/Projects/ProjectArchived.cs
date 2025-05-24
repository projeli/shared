using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Projects;

/// <summary>
/// Represents a notification body for when a project a user is a member of is archived.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ProjectArchived), (int)NotificationType.ProjectArchived)]
public class ProjectArchived : ProjectNotificationBody
{
    /// <summary>
    /// The user who archived the project.
    /// </summary>
    public required string PerformerId { get; set; }
}