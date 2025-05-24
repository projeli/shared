using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Projects;

/// <summary>
/// Represents a notification body for when a project a user was a member of is deleted.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ProjectDeleted), (int)NotificationType.ProjectDeleted)]
public class ProjectDeleted : ProjectNotificationBody
{
    /// <summary>
    /// The name of the project that was deleted.
    /// </summary>
    public required string ProjectName { get; set; }

    /// <summary>
    /// The user who deleted the project.
    /// </summary>
    public required string PerformerId { get; set; }
}