namespace Projeli.Shared.Domain.Models.Notifications;

public enum NotificationType : ushort
{
    ProjectPublished = 1,
    ProjectArchived = 2,
    ProjectMemberAdded = 51,
    ProjectMemberRemoved = 52,
    ProjectDeleted = 200,
    
    WikiPublished = 201,
    WikiArchived = 202,
    WikiPagePublished = 251,
    WikiPageArchived = 252,
    WikiPageDeleted = 300,
    WikiDeleted = 400,
}