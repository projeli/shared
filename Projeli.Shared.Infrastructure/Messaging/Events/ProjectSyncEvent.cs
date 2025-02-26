using MassTransit;

namespace Projeli.Shared.Infrastructure.Messaging.Events;

[EntityName("ProjectSync")]
public class ProjectSyncEvent
{
    public Ulid ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string ProjectSlug { get; set; }
    public List<ProjectMember> Members { get; set; }
    
    
    public class ProjectMember
    {
        public string UserId { get; set; }
        public bool IsOwner { get; set; }
    }
}