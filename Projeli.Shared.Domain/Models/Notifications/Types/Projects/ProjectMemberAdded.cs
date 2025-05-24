using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Projects;

/// <summary>
/// Represents a notification body for when a user is added to a project.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ProjectMemberAdded), (int)NotificationType.ProjectMemberAdded)]
public class ProjectMemberAdded : ProjectNotificationBody
{
    /// <summary>
    /// The user who added the member to the project.
    /// </summary>
    public required string PerformerId { get; set; }
}