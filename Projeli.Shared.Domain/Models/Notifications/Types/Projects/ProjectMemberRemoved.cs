using System.Text.Json.Serialization;

namespace Projeli.Shared.Domain.Models.Notifications.Types.Projects;

/// <summary>
/// Represents a notification body for when a user is removed from a project.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ProjectMemberRemoved), (int)NotificationType.ProjectMemberRemoved)]
public class ProjectMemberRemoved : ProjectNotificationBody;