using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Projects;

/// <summary>
/// Represents a notification body for when a project a user is a member of is published.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ProjectPublished), (int)NotificationType.ProjectPublished)]
public class ProjectPublished : ProjectNotificationBody
{
    /// <summary>
    /// The user who published the project.
    /// </summary>
    public required string PerformerId { get; set; }
}