using System.Text.Json.Serialization;
using Projeli.Shared.Domain.Models.Notifications.Types.Projects;
using Projeli.Shared.Domain.Models.Notifications.Types.Wikis;

namespace Projeli.Shared.Domain.Models.Notifications;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ProjectPublished), (int)NotificationType.ProjectPublished)]
[JsonDerivedType(typeof(ProjectArchived), (int)NotificationType.ProjectArchived)]
[JsonDerivedType(typeof(ProjectMemberAdded), (int)NotificationType.ProjectMemberAdded)]
[JsonDerivedType(typeof(ProjectMemberRemoved), (int)NotificationType.ProjectMemberRemoved)]
[JsonDerivedType(typeof(ProjectDeleted), (int)NotificationType.ProjectDeleted)]

[JsonDerivedType(typeof(WikiPublished), (int)NotificationType.WikiPublished)]
[JsonDerivedType(typeof(WikiArchived), (int)NotificationType.WikiArchived)]
[JsonDerivedType(typeof(WikiPagePublished), (int)NotificationType.WikiPagePublished)]
[JsonDerivedType(typeof(WikiPageArchived), (int)NotificationType.WikiPageArchived)]
[JsonDerivedType(typeof(WikiPageDeleted), (int)NotificationType.WikiPageDeleted)]
[JsonDerivedType(typeof(WikiDeleted), (int)NotificationType.WikiDeleted)]
public abstract class NotificationBody;